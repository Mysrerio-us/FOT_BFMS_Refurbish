using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOT_BFMS
{
    public partial class Login : Form
    {

      
      


        public Login()
        {
            InitializeComponent();

            

            textBoxPassword.PasswordChar = '*';
            pictureBoxEyeClose.Visible = true;
            pictureBoxEyeOpen.Visible = false;
            makeDull();
            
        }
        
        private void makeDull()
        {
            roundControlLogin.BackgroundColor = Color.FromArgb(230, 226, 217);
            labelLogin.BackColor = Color.FromArgb(230, 226, 217);
            labelLogin.ForeColor = Color.Black;
        }
        private void makeBright()
        {
            roundControlLogin.BackgroundColor = Color.FromArgb(9, 144, 191);
            labelLogin.BackColor = Color.FromArgb(9, 144, 191);
            labelLogin.ForeColor = Color.White;
        }

        private void roundControl3_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClossApp, "Close");
        }

        private void roundControl4_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text.Equals("Remember me"))
            {
                checkBox1.Text = "Remembered";
            }
            else if (checkBox1.Text.Equals("Remembered"))
            {
                checkBox1.Text = "Remember me";
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            using (Pen blackPen = new Pen(Color.Black, 2))
            {
                int x1 = 20;
                int y1 = 50;
                int x2 = 300;
                int y2 = 50;
                e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
            }
        }

        private void pictureBoxEyeOpen_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            pictureBoxEyeOpen.Visible = false;
            pictureBoxEyeClose.Visible = true;
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void pictureBoxClossApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

       

        private void pictureBoxEyeClose_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
            pictureBoxEyeClose.Visible = false;
            pictureBoxEyeOpen.Visible = true;
        }

        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();

        }

        private void roundControlLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string email = textBoxPassword.Text.Trim();


            using (SqlConnection con = SQLConnect.GetConnection())
            {
                con.Open();

                string query = @"SELECT Password, roles
                         FROM Signup
                         WHERE Username = @username";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@Email", email);


                SqlDataReader reader = cmd.ExecuteReader();

                // Username not found
                if (!reader.Read())
                {
                    MessageBox.Show("Username not found");
                    return;
                }

                string dbPassword = reader["Password"].ToString().Trim();
                string rool = reader["roles"].ToString().Trim();

                // Password incorrect
                if (dbPassword != password)
                {
                    MessageBox.Show("Incorrect password");
                    return;
                }
                Global.Currentuseremail = username;
                // Login success
                MessageBox.Show("Login successful!");


                //RequestUI ru = new RequestUI( username);
                //ru.Show();
                //this.Hide();

                if (rool.Equals("Admin",
                    StringComparison.OrdinalIgnoreCase))
                {
                    AdminDashboard ad = new AdminDashboard(username);
                    ad.Show();
                    
                }
                else if (rool.Equals("Member",StringComparison.OrdinalIgnoreCase)|| rool.Equals("User", StringComparison.OrdinalIgnoreCase))
                {
                    MembersUI md = new MembersUI();
                    md.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Role");
                    return;
                }

                this.Hide();
            }
        }
        private void loginButonCheck()
        {
            if(string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                roundControlLogin.Enabled = false;
                makeDull();
            }
            else
            {
                roundControlLogin.Enabled = true;
                makeBright();
            }
        }


        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            loginButonCheck();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            loginButonCheck();
        }

        private void roundControlLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
