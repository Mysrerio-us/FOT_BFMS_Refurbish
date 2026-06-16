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
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BFMS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
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
            // TODO: This line of code loads data into the 'bFMSDataSet.signup' table. You can move, or remove it, as needed.
            // this.signupTableAdapter.Fill(this.bFMSDataSet.signup);
            LoadMembers();
            textBox1.Text = "Search using email or firstname";
            textBox1.ForeColor = Color.Gray;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string roll = comboBox1.Text;

                con.Open();

                string query = "";

                SqlCommand cmd;

                if (roll == "All")
                {
                    query = "SELECT * FROM signup";
                    cmd = new SqlCommand(query, con);
                }
                else
                {
                    query = "SELECT * FROM signup WHERE Roll = @roll";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@roll", roll);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvMembers.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMembers()
        {
            try
            {
                con.Open();

                string query = @"
        SELECT 
        userID,
        Username,
        FirstName,
        LastName,
        Email,
        REPLICATE('*', LEN(Password)) AS password,
        PhoneNumber,
        REPLICATE('*', LEN(OTP)) AS OTP,
        createdDate,
        Roll
        FROM signup";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvMembers.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM signup WHERE UserID=@id", con);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Member Deleted");

                LoadMembers();
            }
            else
            {
                MessageBox.Show("Please select a member first");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM signup WHERE FirstName LIKE @search + '%' OR Email LIKE @search + '%'",
                                        con);

            cmd.Parameters.AddWithValue("@search", textBox1.Text);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            DataTable dt = new DataTable();
            dt.Clear();

            sda.Fill(dt);

            dgvMembers.DataSource = dt;
        }
    }
    }

