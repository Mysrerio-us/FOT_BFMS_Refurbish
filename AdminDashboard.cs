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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FOT_BFMS
{
    public partial class AdminDashboard : Form
    {
        string loggedUsername;
        public AdminDashboard(string username)
        {
            InitializeComponent();
            loggedUsername = username;
        }

        public AdminDashboard()
        {
            InitializeComponent();
            
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            
            label7.Text = loggedUsername;
            chart1.Series.Clear();

            Series s = new Series();

            s.ChartType = SeriesChartType.Line;

            s.BorderWidth = 3;

            s.Points.AddXY("Jan", 90000);
            s.Points.AddXY("Feb", 110000);
            s.Points.AddXY("Mar", 120000);
            s.Points.AddXY("Apr", 140000);
            s.Points.AddXY("May", 165000);
            s.Points.AddXY("Jun", 184500);

            chart1.Series.Add(s);

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor =
                Color.LightGray;

            chart1.Legends.Clear();


           



            ShowCentralFund();
            UpdateMemberCount();
            UpdateProgressBar();
            UpdateChart();
            UpdateDatagridView();
            LoadTopDepositors();
            countPendingRequests();
        }

        private void ShowCentralFund()
        {
            try
            {
                using (SqlConnection conn = SQLConnect.GetConnection())
                {
                    conn.Open();



                    //3. Load Central Fund Balance
                    string queryBalance = "SELECT Amount FROM CentralFund WHERE AId = 1";
                    SqlDataAdapter daBalance = new SqlDataAdapter(queryBalance, conn);
                    DataTable dtBalance = new DataTable();
                    daBalance.Fill(dtBalance);
                    label10.Text = "Rs." + dtBalance.Rows[0][0].ToString();
                    label36.Text = "Rs." + dtBalance.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void UpdateMemberCount()
        {
            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    con.Open();
                    // Count rows where the Role is either 'User' or 'Member'
                    string query = "SELECT COUNT(*) FROM Signup WHERE roles IN ('User', 'Member')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int totalMembers = (int)cmd.ExecuteScalar();

                        // Assuming you have a label named lblMemberCount on your dashboard
                        label16.Text = totalMembers.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading member count: " + ex.Message);
            }
        }
        private void UpdateProgressBar()
        {
            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    con.Open();
                    // Fetch the current balance from the database
                    string query = "SELECT Amount FROM CentralFund WHERE AId = 1";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            decimal currentBalance = Convert.ToDecimal(result);

                            // Update the Progress Bar
                            // Ensure the value does not exceed the Maximum (500,000)
                            int progressValue = (int)Math.Min(currentBalance, 500000);
                            progressBar1.Value = progressValue;

                            // Update your label text
                            //lblCurrentAmount.Text = $"Rs {currentBalance:N0}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading progress: " + ex.Message);
            }
        }

        private void UpdateChart()
        {
            chart1.Series.Clear();
            Series sa = new Series("Balance")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.Blue
            };
            chart1.Series.Add(sa);

            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    con.Open();
                    // This query gets all deposits and withdrawals for the current year
                    string query = @"
                SELECT MONTH(DepositDate) as M, SUM(Amount) as NetChange FROM Deposit 
                WHERE YEAR(DepositDate) = YEAR(GETDATE()) GROUP BY MONTH(DepositDate)
                UNION ALL
                SELECT MONTH(DateNeeded), -SUM(Amount) FROM Withdraw 
                WHERE YEAR(DateNeeded) = YEAR(GETDATE()) GROUP BY MONTH(DateNeeded)";

                    DataTable dt = new DataTable();
                    new SqlDataAdapter(query, con).Fill(dt);

                    // Group by month to get net change
                    var monthlyData = dt.AsEnumerable()
                        .GroupBy(row => row.Field<int>("M"))
                        .Select(g => new { Month = g.Key, Total = g.Sum(r => r.Field<decimal>("NetChange")) })
                        .OrderBy(x => x.Month);

                    decimal runningTotal = 0;
                    string[] monthNames = { "", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

                    foreach (var item in monthlyData)
                    {
                        runningTotal += item.Total;
                        sa.Points.AddXY(monthNames[item.Month], runningTotal);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chart Error: " + ex.Message);
            }
        }
        private void UpdateDatagridView()
        {
            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    con.Open();
                    string query = "SELECT RequestTitle, Status FROM RequestTable";
                    DataTable dt = new DataTable();
                    new SqlDataAdapter(query, con).Fill(dt);
                    dgvActivities.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGrid Error: " + ex.Message);



            }
        }

        private void countPendingRequests()
        {
            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    con.Open();
                    string query = "SELECT COUNT(*) AS PendingCount FROM RequestTable\r\nWHERE Status = 'Pending';";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int pendingCount = (int)cmd.ExecuteScalar();
                        label29.Text = pendingCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting pending requests: " + ex.Message);
            }
        }


        private void LoadTopDepositors()
        {
            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    con.Open();

                    string query = @"
                                    SELECT TOP 5 Amount, Email
                                    FROM Deposit
                                    ORDER BY Amount DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvContributors.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading deposit data: " + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MembersForm frm = new MembersForm();
            frm.Show();
            this.Hide();
        }

        private void pnlHelp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnalyticsForm frm = new AnalyticsForm();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            frm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        

        private void label34_Click(object sender, EventArgs e)
        {

        }



        private void btnMembers_Click(object sender, EventArgs e)
        {
            MembersForm frm = new MembersForm();

            frm.Show();

            this.Hide();
        }


        private void button14_Click_1(object sender, EventArgs e)
        {

            MembersForm frm = new MembersForm();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CentralFundForm frm = new CentralFundForm();
            frm.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RequestApprovalForm frm = new RequestApprovalForm();
            frm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();

                this.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RequestApprovalForm frm = new RequestApprovalForm();
            frm.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            BackupForm frm = new BackupForm();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.Show();
            this.Hide();
        
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            WithdrawRequestForm frm = new WithdrawRequestForm();
            frm.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DepositMoneyUI frm = new DepositMoneyUI();
            frm.ShowDialog();
            
        }
    }
}
