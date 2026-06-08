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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxPasswordAgain.PasswordChar = '*';

            pictureBoxEyeClosePW.Visible = true; 
            pictureBoxEyeOpenPW.Visible = false;
            pictureBoxEyeClosePWA.Visible = true;
            pictureBoxEyeOpenPWA.Visible = false;

        }
        private void Signup_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClossApp, "Close Application");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void roundControl3_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void roundControlRightWing_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBoxClossApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void pictureBoxEyeOpenPW_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            pictureBoxEyeOpenPW.Visible = false;
            pictureBoxEyeClosePW.Visible = true;
        }

        private void pictureBoxEyeClosePW_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
            pictureBoxEyeOpenPW.Visible = true;
            pictureBoxEyeClosePW.Visible = false;
        }

        private void pictureBoxEyeOpenPWA_Click(object sender, EventArgs e)
        {
            textBoxPasswordAgain.PasswordChar = '*';
            pictureBoxEyeOpenPWA.Visible = false;
            pictureBoxEyeClosePWA.Visible = true;
        }

        private void pictureBoxEyeClosePWA_Click(object sender, EventArgs e)
        {
            textBoxPasswordAgain.PasswordChar = '\0';
            pictureBoxEyeOpenPWA.Visible = true;
            pictureBoxEyeClosePWA.Visible = false;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
