using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOT_BFMS
{
    public partial class MembersUI : Form
    {
        public MembersUI()
        {
            InitializeComponent();
        }

        private void roundControl1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void roundControl2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundControl2_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void roundControl5_Load(object sender, EventArgs e)
        {

        }

        private void roundControl2_Load_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepositMoneyUI depositWindow = new DepositMoneyUI();
            depositWindow.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RequestUI requestWindow = new RequestUI();
            requestWindow.ShowDialog();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private void roundControl3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Log out from Member Account !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            login.Show();
            this.Hide();
                

        }

        private void MembersUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bFMSDataSet14.Deposit' table. You can move, or remove it, as needed.
            this.depositTableAdapter.Fill(this.bFMSDataSet14.Deposit);
            // TODO: This line of code loads data into the 'bFMSDataSet13.RequestTable' table. You can move, or remove it, as needed.
            this.requestTableTableAdapter1.Fill(this.bFMSDataSet13.RequestTable);
            // TODO: This line of code loads data into the 'bFMSDataSet12.RequestTable' table. You can move, or remove it, as needed.
            this.requestTableTableAdapter.Fill(this.bFMSDataSet12.RequestTable);
            LoadActiveRequestStatus();
            label4.Text = Global.Currentuseremail; // Display the current user's name
            ShowCentralFund();
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
                    label7.Text = "Rs." + dtBalance.Rows[0][0].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadActiveRequestStatus()
        {
            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    // IMPORTANT: Add ORDER BY to get the latest entry
                    string query = @"SELECT TOP 1 RequestTitle, RequestAmount, Status 
                             FROM RequestTable 
                             WHERE Email = @Email 
                             ORDER BY DataNeeded DESC"; // Replace DateCreated with your column

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", Global.Currentuseremail);
                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label17.Text = reader["RequestTitle"].ToString();
                                label15.Text = "Rs " + reader["RequestAmount"].ToString();

                                string status = reader["Status"].ToString();
                                button5.Text = status;

                                // Improved color logic
                                if (status.Equals("Approved", StringComparison.OrdinalIgnoreCase))
                                    button5.ForeColor = Color.Green;
                                else if (status.Equals("Rejected", StringComparison.OrdinalIgnoreCase))
                                    button5.ForeColor = Color.Red;
                                else
                                    button5.ForeColor = Color.Orange; // Covers "Pending" or other states
                            }
                            else
                            {
                                // No records found for this user
                                button5.Text = "No Requests";
                                button5.ForeColor = Color.Gray;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading request: " + ex.Message);
            }
        }
    }
}
