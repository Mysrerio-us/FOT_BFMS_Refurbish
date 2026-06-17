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
    public partial class CentralFundForm : Form
    {
        public CentralFundForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard();

            frm.Show();

            this.Hide();
        }

        private void CentralFundForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = SQLConnect.GetConnection())
                {
                    conn.Open();

                    // 1. Load Deposits
                    string queryDeposits = "SELECT * FROM Deposit"; 
                    SqlDataAdapter daDeposits = new SqlDataAdapter(queryDeposits, conn);
                    DataTable dtDeposits = new DataTable();
                    daDeposits.Fill(dtDeposits);
                    dataGridView1.DataSource = dtDeposits;

                    // 2. Load Withdrawals
                    string queryWithdrawals = "SELECT * FROM Withdraw"; 
                    SqlDataAdapter daWithdrawals = new SqlDataAdapter(queryWithdrawals, conn);
                    DataTable dtWithdrawals = new DataTable();
                    daWithdrawals.Fill(dtWithdrawals);
                    dataGridView2.DataSource = dtWithdrawals;

                    //3. Load Central Fund Balance
                    string queryBalance = "SELECT Amount FROM CentralFund WHERE AId = 1";
                    SqlDataAdapter daBalance = new SqlDataAdapter(queryBalance, conn);
                    DataTable dtBalance = new DataTable();
                    daBalance.Fill(dtBalance);
                    label3.Text = "Rs." +dtBalance.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e) // Assuming this is the Deposit button
        {
            // Use the '!=' operator for null checks to avoid potential exceptions
            if (Global.Currentuseremail != null)
            {
                DepositMoneyUI frm = new DepositMoneyUI();
                frm.Show();
                // Optionally refresh the data grid after closing the deposit form
            }
            else
            {
                MessageBox.Show("Please log in to make a deposit.");
            }
        }

        private void button1_Click(object sender, EventArgs e) // Assuming this is the Withdraw button
        {
            if (Global.Currentuseremail != null)
            {
                WithdrawRequestForm frm = new WithdrawRequestForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please log in to make a withdrawal.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WithdrawRequestForm frm = new WithdrawRequestForm();
            frm.ShowDialog();
        }
    }
}
