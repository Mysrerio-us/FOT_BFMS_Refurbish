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
    public partial class DepositMoneyUI : Form
    {
        public DepositMoneyUI()
        {
            
            InitializeComponent();
            btnSubmit.BackColor = Color.FromArgb(0, 123, 255); // Bootstrap primary color
            btnCancel.BackColor = Color.FromArgb(220, 53, 69); // Bootstrap danger color
        }

        private void DepositMoneyUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }


      

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox1.Text.Trim(), out decimal depositAmount))
            {
                MessageBox.Show($"Could not parse: '{textBox1.Text}'", "Debug Info"); // Temporary debug
                return;
            }
            //decimal.TryParse(textBox1.Text.Trim(), out decimal depositAmount);

            if (depositAmount <= 0)
            {
                MessageBox.Show("Deposit amount must be greater than zero.");
                return;
            }

            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    con.Open();

                    // Start a transaction to ensure both operations succeed or fail together
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // STEP 1: Insert into Deposit table
                            string insertQuery = @"INSERT INTO Deposit (Amount, DepositDate, Email) 
                                           VALUES (@Amount, @Date, @Email)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Amount", depositAmount);
                                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                                cmd.Parameters.AddWithValue("@Email", Global.Currentuseremail);
                                cmd.ExecuteNonQuery();
                            }

                            // STEP 2: Update CentralFund table (ADD to the balance)
                            string updateQuery = @"UPDATE CentralFund
                                           SET Amount = Amount + @Amount
                                           WHERE AId = 1";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@Amount", depositAmount);
                                updateCmd.ExecuteNonQuery();
                            }

                            // Commit both operations
                            transaction.Commit();
                            MessageBox.Show("Deposit successful and Central Fund updated!");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            // If any error occurs, revert both changes
                            transaction.Rollback();
                            throw new Exception("Database transaction failed. Changes rolled back. Details: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
