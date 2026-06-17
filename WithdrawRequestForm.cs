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
            btnSubmit.BackColor = Color.FromArgb(0, 123, 255); // Bootstrap primary color
            btnCancel.BackColor = Color.FromArgb(220, 53, 69); // Bootstrap danger color
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Validate Input Data First
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || !decimal.TryParse(txtAmount.Text, out decimal withdrawalAmount))
            {
                MessageBox.Show("Please enter a valid title and numeric amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Negative amounts or zero should not be allowed
            if (withdrawalAmount <= 0)
            {
                MessageBox.Show("Withdrawal amount must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Show Confirmation Message Box
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
                        con.Open();

                        using (SqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {
                                // CHECK 1: Verify available balance in CentralFund (AId = 1)
                                string checkBalanceQuery = "SELECT Amount FROM CentralFund WHERE AId = 1";
                                decimal currentBalance = 0;

                                using (SqlCommand checkCmd = new SqlCommand(checkBalanceQuery, con, transaction))
                                {
                                    object objBalance = checkCmd.ExecuteScalar();
                                    if (objBalance != null && objBalance != DBNull.Value)
                                    {
                                        currentBalance = Convert.ToDecimal(objBalance);
                                    }
                                }

                                // Block transaction if funds are insufficient
                                if (withdrawalAmount > currentBalance)
                                {
                                    MessageBox.Show($"Insufficient funds! Available balance is: {currentBalance:C}.\nYour request: {withdrawalAmount:C}.",
                                                    "Transaction Denied",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Warning);

                                    transaction.Rollback(); // Cancel the transaction
                                    return; // Stop execution and keep the form open
                                }

                                // STEP 2: Insert into Withdraw table
                                string insertQuery = @"INSERT INTO Withdraw (Title, Amount, DateNeeded, Reason, Email) 
                                               VALUES (@Title, @Amount, @DateNeeded, @Reason, @Email)";

                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con, transaction))
                                {
                                    insertCmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                                    insertCmd.Parameters.AddWithValue("@Amount", withdrawalAmount);
                                    insertCmd.Parameters.AddWithValue("@DateNeeded", dtpDateNeeded.Value.Date);
                                    insertCmd.Parameters.AddWithValue("@Reason", rtbReason.Text);
                                    insertCmd.Parameters.AddWithValue("@Email", Global.Currentuseremail);

                                    insertCmd.ExecuteNonQuery();
                                }

                                // STEP 3: Update CentralFund table
                                string updateQuery = @"UPDATE CentralFund
                                               SET Amount = Amount - @Amount
                                               WHERE AId = 1";

                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con, transaction))
                                {
                                    updateCmd.Parameters.AddWithValue("@Amount", withdrawalAmount);
                                    updateCmd.ExecuteNonQuery();
                                }

                                // Commit changes if everything passed safely
                                transaction.Commit();
                                MessageBox.Show("Withdrawal request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw new Exception("Database transaction failed. Changes rolled back. Details: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtTitle.Clear();
            rtbReason.Clear();

        }
    }
}
