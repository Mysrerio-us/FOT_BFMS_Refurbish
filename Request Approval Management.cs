using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOT_BFMS
{
    public partial class RequestApprovalForm : Form
    {
        public RequestApprovalForm()
        {
            InitializeComponent();
        }

        private void RequestApprovalForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bFMSDataSet1.RequestTable' table. You can move, or remove it, as needed.
            //this.requestTableTableAdapter.Fill(this.bFMSDataSet1.RequestTable);

            using (SqlConnection con = SQLConnect.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RequestTable", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateStatus("Approved");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateStatus("Rejected");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard();

            frm.Show();

            this.Hide();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateRequestStatus(string email, string status)
        {
            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    // We use Email as the identifier. 
                    // NOTE: Ensure Email is unique or use a Primary Key if one exists.
                    string query = "UPDATE RequestTable SET Status = @Status WHERE Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Email", email);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
        private void UpdateStatus(string newStatus)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Using index 4 for Email and 5 for Status based on your table structure
                string currentStatus = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                // RULE: If already Approved or Rejected, block all changes
                if (currentStatus == "Approved" || currentStatus == "Rejected")
                {
                    MessageBox.Show($"This request has already been finalized as '{currentStatus}' and cannot be changed.");
                    return;
                }

                // Confirmation dialog
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to mark this request as {newStatus}?",
                                                            "Confirm Action", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    UpdateRequestStatus(email, newStatus);
                    dataGridView1.SelectedRows[0].Cells[5].Value = newStatus;
                    MessageBox.Show($"Request {newStatus} successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a full row to update.");
            }
        }
    }
}