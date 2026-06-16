using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FOT_BFMS
{
    public partial class RequestUI : Form

    {
        string userEmail;
        public RequestUI()
        {
            InitializeComponent();
            
        }
       

        public RequestUI(string username)
        {
            InitializeComponent();
            this.userEmail = username;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BFMS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();

                // Check if email exists in signup table
                //string checkQuery = "SELECT COUNT(*) FROM signup WHERE Email = @Email";

                // SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                //checkCmd.Parameters.AddWithValue("@Email",Global.Currentuseremail);

                // int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                int count = 1;
                if (count > 0)
                {
                    // Insert into RequestTable
                    string query = @"INSERT INTO RequestTable
            (RequestTitle, RequestAmount, DataNeeded, Description, Email)
            VALUES
            (@RequestTitle, @RequestAmount, @DataNeeded, @Description, @Email)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@RequestTitle", textBox1.Text);
                    cmd.Parameters.AddWithValue("@RequestAmount", textBox2.Text);
                    cmd.Parameters.AddWithValue("@DataNeeded", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Description", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", Global.Currentuseremail);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Request Submitted Successfully");
                }
                else
                {
                    MessageBox.Show("Email does not exist in signup table");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

