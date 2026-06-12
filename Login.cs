using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void roundControl2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxEyeOpen_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            pictureBoxEyeOpen.Visible = false;
            pictureBoxEyeClose.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundControl6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundControl6_Load(object sender, EventArgs e)
        {
            
        }

        private void roundControl6_Load_1(object sender, EventArgs e)
        {

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

        private void roundControl8_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxEyeClose_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
            pictureBoxEyeClose.Visible = false;
            pictureBoxEyeOpen.Visible = true;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }


        private void roundControlLogin_Click(object sender, EventArgs e)
        {
            
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

        private void roundControl1_Load(object sender, EventArgs e)
        {

        }

        private void roundControlLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
