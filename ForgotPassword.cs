using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOT_BFMS
{ 
    
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            makeDull();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            // This Regex pattern checks for standard email format:
            // name@domain.extension
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);

        }
        private void resetButtonCheck()
        {
            if (!string.IsNullOrEmpty(textBoxUsername.Text))
            {
                roundControlReset.Enabled = true;
                makeBright();

            }
            else
            {
                roundControlReset.Enabled = false;
                makeDull();

            }
        }

        private void makeDull()
        {
            roundControlReset.BackgroundColor = Color.FromArgb(230, 226, 217);
            labelReset.BackColor = Color.FromArgb(230, 226, 217);
            labelReset.ForeColor = Color.Black;
        }
        private void makeBright()
        {
            roundControlReset.BackgroundColor = Color.FromArgb(9, 144, 191);
            labelReset.BackColor = Color.FromArgb(9, 144, 191);
            labelReset.ForeColor = Color.White;
        }


        private void pictureBoxClossApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            resetButtonCheck();
        }
        
        private void labelReset_Click(object sender, EventArgs e)
        {
            //if clicked, an email should be sent with a temporary password, and a message box should pop up to inform the user that the email has been sent. The user should then be redirected to the login form.
        }

        private void roundControlReset_Click(object sender, EventArgs e)
        {
            //same as above labelReset_click
        }

        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
