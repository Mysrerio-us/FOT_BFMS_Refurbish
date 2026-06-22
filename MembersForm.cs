using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FOT_BFMS
{

    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminDashboard frm =
       new AdminDashboard();

            frm.Show();

            this.Close();
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {


            label2.Text = "(Search using email or firstname)";
            label2.ForeColor = Color.WhiteSmoke;

            LoadMembers();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Ensure an item is actually selected
            if (comboBox1.SelectedItem != null)
            {
                string selectedRole = comboBox1.SelectedItem.ToString();

                // Handle the "All" case to show everything
                if (selectedRole == "All")
                {
                    LoadMembers();
                    return;
                }

                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    try
                    {
                        // Filter by the role column
                        string query = "SELECT userID, userName, FirstName, LastName, Email, PhoneNumber, OTP, roles, CreatedDate " +
                                       "FROM signup WHERE roles = @role";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@role", selectedRole);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dgvMembers.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error filtering data: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a role from the list.");
            }
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMembers()
        {
            using (SqlConnection con = SQLConnect.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT userID, userName, FirstName, LastName, Email, PhoneNumber, OTP, roles, CreatedDate FROM signup";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvMembers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Signup signup = new Signup();
            signup.ShowDialog();

            LoadMembers();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dgvMembers.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvMembers.CurrentRow.Cells[0].Value);

                using (SqlConnection con = SQLConnect.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM signup WHERE UserID=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Member Deleted");
                LoadMembers();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = SQLConnect.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM signup WHERE FirstName LIKE @search + '%' OR Email LIKE @search + '%'", con);
                cmd.Parameters.AddWithValue("@search", textBox1.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvMembers.DataSource = dt;
            }
        }

        private void buttonMember_Click(object sender, EventArgs e)
        {
            // Ensure a valid row is selected
            if (dgvMembers.CurrentRow != null && !dgvMembers.CurrentRow.IsNewRow)
            {
                string currentRole = dgvMembers.CurrentRow.Cells[8].Value?.ToString();
                int id = Convert.ToInt32(dgvMembers.CurrentRow.Cells[0].Value);

                // Prevent downgrading if already a Member
                if (currentRole == "User")
                {
                    MessageBox.Show("This user is already a member.");
                    return;
                }

                // Confirm action
                DialogResult result = MessageBox.Show("Are you sure you want to change this role to 'User'?",
                                                    "Confirm Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = SQLConnect.GetConnection())
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE signup SET roles = 'User' WHERE UserID=@id", con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Member Role Updated Successfully.");
                    LoadMembers();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user row.");
            }
        }
    }
}
