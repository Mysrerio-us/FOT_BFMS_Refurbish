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
    public partial class WithdrawRequestForm : Form
    {
        public WithdrawRequestForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Show Confirmation Message Box
            DialogResult result = MessageBox.Show("Are you sure you want to submit this withdrawal request?",
                                                  "Confirm Submission",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = SQLConnect.GetConnection())
                    {
                        // 2. SQL Insert Query
                        // Assuming columns: Title, Amount, DateNeeded, Reason, Email
                        string query = @"INSERT INTO Withdraw (Title, Amount, DateNeeded, Reason, Email) 
                                 VALUES (@Title, @Amount, @DateNeeded, @Reason, @Email)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Map your textboxes to the parameters
                            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                            cmd.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text));
                            cmd.Parameters.AddWithValue("@DateNeeded", dtpDateNeeded.Value.Date);
                            cmd.Parameters.AddWithValue("@Reason", rtbReason.Text);
                            cmd.Parameters.AddWithValue("@Email", Global.Currentuseremail); // Assuming your global class stores the email

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Withdrawal request submitted successfully!");
                    this.Close(); // Close the form after submission
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting request: " + ex.Message);
                }
            }
        }
    }
}
