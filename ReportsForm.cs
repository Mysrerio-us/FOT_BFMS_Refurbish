using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOT_BFMS
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            dgvReportsWithdraw.Visible = false;
            dgvReportsDeposit.Visible = false;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem?.ToString();
            DateTime fromDate = dtFrom.Value.Date;
            DateTime toDate = dtTo.Value.Date;

            if (reportType == "Withdrawals")
            {
                dgvReportsWithdraw.Visible = true;
                dgvReportsDeposit.Visible = false;
                LoadReport("SELECT * FROM Withdraw WHERE CreatedAt BETWEEN @from AND @to", dgvReportsWithdraw, fromDate, toDate);
            }
            else if (reportType == "Deposits")
            {
                dgvReportsWithdraw.Visible = false;
                dgvReportsDeposit.Visible = true;
                LoadReport("SELECT * FROM Deposit WHERE DepositDate BETWEEN @from AND @to", dgvReportsDeposit, fromDate, toDate);
            }
        }

        private void LoadReport(string query, DataGridView dgv, DateTime from, DateTime to)
        {
            using (SqlConnection con = SQLConnect.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to.AddDays(1).AddSeconds(-1)); // Include full end date

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void buttonPdf_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvReportsWithdraw.Visible ? dgvReportsWithdraw : dgvReportsDeposit;

            if (dgv.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf", FileName = "Report_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + "_BFMS.pdf" };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(PageSize.A4, 30f, 30f, 30f, 60f); // Increased bottom margin for footer
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        // 1. Add Logo (Modern look)
                        System.Drawing.Image img = Properties.Resources.LOGO;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ms.ToArray());

                            logo.ScaleToFit(100f, 100f); // Optional: Adjust size if needed
                            logo.Alignment = Element.ALIGN_CENTER; // This centers the logo
                            logo.SpacingAfter = 10f; // Add space between logo and title

                            doc.Add(logo);
                        }


                        string logoPath = Path.Combine(Application.StartupPath, "LOGO.png"); // Adjust path if needed
                        if (File.Exists(logoPath))
                        {
                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                            logo.ScaleToFit(80f, 80f);
                            logo.Alignment = Element.ALIGN_LEFT;
                            doc.Add(logo);
                        }

                        // 2. Report Title
                        iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                        Paragraph p = new Paragraph("Batch Fund Management System - " + cmbReportType.SelectedItem.ToString(), titleFont);
                        p.Alignment = Element.ALIGN_CENTER;
                        p.SpacingAfter = 20f;
                        doc.Add(p);

                        // 3. Modern Table Styling
                        PdfPTable pdfTable = new PdfPTable(dt.Columns.Count) { WidthPercentage = 100 };

                        // Header Styling
                        foreach (DataColumn column in dt.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                            {
                                BackgroundColor = new BaseColor(41, 128, 185), // Modern Blue
                                Padding = 5f,
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };
                            pdfTable.AddCell(cell);
                        }

                        // Row Styling
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (object cellValue in row.ItemArray)
                            {
                                pdfTable.AddCell(new PdfPCell(new Phrase(cellValue.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9))) { Padding = 4f });
                            }
                        }
                        doc.Add(pdfTable);

                        // 4. Footer with Copyright and Timestamp
                        string footerText = $"Batch Fund Management System © 2026 | Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                        ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER,
                            new Phrase(footerText, FontFactory.GetFont(FontFactory.HELVETICA, 8)),
                            300, 30, 0);

                        doc.Close();
                        MessageBox.Show("Report generated successfully with branding!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }
    }
}
