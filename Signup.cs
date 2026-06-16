using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FOT_BFMS
{
    public partial class Signup : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BFMS;Integrated Security=True;Encrypt=True;Encrypt=False;;TrustServerCertificate=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public static Login login = new Login();
        string randomNumber;
        public Signup()
        {
            InitializeComponent();

            textBoxPassword.PasswordChar = '*';         //default password char is set to '*'
            textBoxPasswordAgain.PasswordChar = '*';

            pictureBoxEyeClosePW.Visible = true;        //default for the eye icons is set to closed eye
            pictureBoxEyeOpenPW.Visible = false;
            pictureBoxEyeClosePWA.Visible = true;
            pictureBoxEyeOpenPWA.Visible = false;

            pictureBoxOTC.Visible = false;              //defaults for the phone number confirmation icons are set to hidden
            pictureBoxOTW.Visible = true;
            pictureBoxPNC.Visible = false;
            pictureBoxPNW.Visible = true;

            maskedTextBoxPN.PromptChar = ' ';           //masked text box defaults _ this char so make it invisible
            maskedTextBoxOTP.PromptChar = ' ';

            roundControlSignup.Enabled = false;                   //disable the Sign Up button until OTP is verified
            labelSignup.Enabled = false;
        }



        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            // This Regex pattern checks for standard email format:
            // name@domain.extension
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);

        }
        private bool ValidateForm()                     //checks if any of the required fields are empty and highlight them, show message box
        {
            bool isValid = true;

            var controlsToValidate = new List<Control> { textBoxFirstName,textBoxLastName, textBoxEmail, maskedTextBoxPN, textBoxPassword, textBoxPasswordAgain };

            foreach (var control in controlsToValidate)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    control.BackColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    control.BackColor = Color.FromArgb(230, 226, 217);
                }
            }

            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address (e.g., name@example.com).");
                textBoxEmail.BackColor = Color.Red;
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Please fill in all highlighted fields.");
            }

            return isValid;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            textBoxEmail.BackColor = Color.FromArgb(230, 226, 217);
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            login.Show();
            this.Hide();
        }

        private void pictureBoxClossApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void pictureBoxOTC_Click(object sender, EventArgs e)       //OTP VAlidation
        {
            string userOTP = maskedTextBoxOTP.Text.Replace(" ", "").Trim();

            if (string.IsNullOrWhiteSpace(userOTP))
            {
                MessageBox.Show("Please enter the OTP sent to your phone.");
                return;
            }
            if (userOTP == randomNumber)
            {
                MessageBox.Show("OTP Verified Successfully! Click Sign up.");
                roundControlSignup.BackgroundColor = Color.FromArgb(9, 144, 191);   // Enable the Sign Up button by changing its color
                labelSignup.BackColor = Color.FromArgb(9, 144, 191);

                maskedTextBoxOTP.Enabled = false;
                pictureBoxOTC.Enabled = false;

                roundControlSignup.Enabled = true;
                labelSignup.Enabled = true;
                //highlighted fields
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
                maskedTextBoxOTP.Clear();
                maskedTextBoxOTP.Focus();
            }
        }

        private async void pictureBoxPNC_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            else if(textBoxPassword.Text != textBoxPasswordAgain.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
                textBoxPassword.BackColor = Color.Red;
                textBoxPasswordAgain.BackColor = Color.Red;

                await Task.Delay(2000); 

                textBoxPassword.BackColor = Color.FromArgb(230, 226, 217);
                textBoxPasswordAgain.BackColor = Color.FromArgb(230, 226, 217);
                return;
            }

            string rawPhoneNumber = maskedTextBoxPN.Text.Replace(" ", "").Replace("-", ""); // Remove spaces and dashes for validation

            if (rawPhoneNumber.Length < 10)
            {
                MessageBox.Show("Please enter a valid phone number.Ex: 0771234567");
                maskedTextBoxPN.Focus();
                return;
            }

            Random rnd = new Random();
            randomNumber = (rnd.Next(100000, 999999)).ToString();
            MessageBox.Show("OTP Sent Successfully! : "+randomNumber);

            //// 3. Confirmation Dialog
            //DialogResult dialogResult = MessageBox.Show(
            //    $"Is this the correct phone number?\n\n{maskedTextBoxPN.Text}\n\n" +
            //    "Click 'Yes' to send OTP, or 'No' to go back and edit.",
            //    "Confirm Phone Number",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);

            //if (dialogResult == DialogResult.No)
            //{
            //    // If User wants to change it; just return to the form
            //    maskedTextBoxPN.Focus();
            //    return;
            //}
            //else
            //{
            //    string name = textBoxFirstName.Text;
            //    string apiKey = "5282|cIwMQwBK7ZqJlj7qG7ToctqxLJvgDjr39LNtfZfuc2388d69";

            //    Random rnd = new Random();
            //    randomNumber = (rnd.Next(100000, 999999)).ToString();

            //    // The JSON structure required by Text.lk API
            //    var payload = new
            //    {
            //        recipient = rawPhoneNumber,
            //        sender_id = "TextLKDemo", // registered sender ID from text.lk
            //        type = "plain",
            //        message = $"Hey {name}, your OTP is {randomNumber}"
            //    };

            //    string json = JsonSerializer.Serialize(payload);

            //    using (HttpClient client = new HttpClient())
            //    {
            //        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            //        client.DefaultRequestHeaders.Add("Accept", "application/json");

            //        var content = new StringContent(json, Encoding.UTF8, "application/json");

            //        try
            //        {
            //            HttpResponseMessage response = await client.PostAsync("https://app.text.lk/api/v3/sms/send", content);
            //            string result = await response.Content.ReadAsStringAsync();

            //            if (response.IsSuccessStatusCode)
            //            {
            //                MessageBox.Show("OTP Sent Successfully!");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Error: " + result);
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Exception: " + ex.Message);
            //        }
            //    }
            //}
            
        }

        private void maskedTextBoxPN_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxPN.Text))
            {
                pictureBoxPNC.Visible = false;
                pictureBoxPNW.Visible = true;

            }
            else
            {
                pictureBoxPNC.Visible = true;
                pictureBoxPNW.Visible = false;
            }
        }
        private void maskedTextBoxOTP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxOTP.Text))
            {
                pictureBoxOTC.Visible = false;
                pictureBoxOTW.Visible = true;

            }
            else
            {
                pictureBoxOTC.Visible = true;
                pictureBoxOTW.Visible = false;
            }
        }

        private void maskedTextBoxPN_Click(object sender, EventArgs e)
        {
            maskedTextBoxPN.Select(0, 0);
        }
        private void maskedTextBoxOTP_Click(object sender, EventArgs e)
        {
            maskedTextBoxOTP.Select(0, 0);
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            textBoxFirstName.BackColor = Color.FromArgb(230, 226, 217);
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            textBoxLastName.BackColor = Color.FromArgb(230, 226, 217);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.FromArgb(230, 226, 217);
        }

        private void textBoxPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            textBoxPasswordAgain.BackColor = Color.FromArgb(230, 226, 217);
        }

        private void roundControlSignup_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
            INSERT();
        }

        private void labelSignup_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("@fname", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@lName", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
            cmd.Parameters.AddWithValue("@pno", maskedTextBoxPN.Text);
            cmd.Parameters.AddWithValue("@OTP", maskedTextBoxOTP.Text);
            cmd.Parameters.AddWithValue("@username", textBoxFirstName.Text.ToLower() + textBoxLastName.Text.ToLower());

        }
        private void INSERT()
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text) ||
                string.IsNullOrEmpty(textBoxLastName.Text) ||
                string.IsNullOrEmpty(textBoxEmail.Text) ||
                string.IsNullOrEmpty(textBoxPassword.Text))


            {
                MessageBox.Show("Complete all required fields");
                return;
            }

            try
            {

                cmd = new SqlCommand(
                "INSERT INTO signup " +
                "(Username, FirstName, LastName, Email, Password, PhoneNumber,OTP) " +
                "VALUES " +
                "(@email, @fname, @lName, @email, @password, @pno,@OTP)", con);

                Parameters();

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("Record inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
