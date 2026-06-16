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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter both Amount and Transfer ID.");
                return;
            }

            try
            {
                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    // Note: We exclude TransferID from the query because it is an IDENTITY column
                    string query = @"INSERT INTO Deposit (Amount, DepositDate, Email) 
                             VALUES (@Amount, @Date, @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Amount", decimal.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Email", Global.Currentuseremail);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Deposit details submitted successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
