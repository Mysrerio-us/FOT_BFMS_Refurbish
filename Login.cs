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
    }
}
