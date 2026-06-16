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
            LoadActiveRequestStatus();
            label4.Text = Global.Currentuseremail; // Display the current user's name
        }

        private void LoadActiveRequestStatus()
        {
            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    // Select all three fields
                    string query = "SELECT RequestTitle, RequestAmount, Status FROM RequestTable WHERE Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", Global.Currentuseremail);

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If a request exists
                            {
                                // Assign data to labels
                                label17.Text = reader["RequestTitle"].ToString(); // Assume label17
                                label15.Text = "Rs " + reader["RequestAmount"].ToString(); // Assume label15
                                string status = reader["Status"].ToString();

                                // Update status label
                                button5.Text = status;

                                // Set colors
                                if (status == "Approved") button5.ForeColor = Color.Green;
                                else if (status == "Rejected") button5.ForeColor = Color.Red;
                                else button5.ForeColor = Color.Orange;
                            }
                            else
                            {
                                button5.Text = "Still Pending";
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
