using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FOT_BFMS
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MembersForm frm = new MembersForm();
            frm.Show();
            this.Hide();
        }

        private void pnlHelp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            frm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            Series s = new Series();

            s.ChartType = SeriesChartType.Line;

            s.BorderWidth = 3;

            s.Points.AddXY("Jan", 90000);
            s.Points.AddXY("Feb", 110000);
            s.Points.AddXY("Mar", 120000);
            s.Points.AddXY("Apr", 140000);
            s.Points.AddXY("May", 165000);
            s.Points.AddXY("Jun", 184500);

            chart1.Series.Add(s);

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor =
                Color.LightGray;

            chart1.Legends.Clear();


            
            dgvContributors.Rows.Add("1", "SK Fernando", "45000");
            dgvContributors.Rows.Add("2", "John Perera", "38000");
            dgvContributors.Rows.Add("3", "Alex Kumar", "30000");
            dgvContributors.Rows.Add("4", "Nimali Silva", "25000");
            dgvContributors.Rows.Add("5", "Dinuka Rajapaksa", "18500");


            dgvActivities.Rows.Add(
"SK deposited Rs 5,000 to central fund",
"Today, 10:30 AM");

            dgvActivities.Rows.Add(
            "Admin withdrew Rs 3,000 for event expenses",
            "Today, 09:15 AM");

            dgvActivities.Rows.Add(
            "New member John Silva joined the batch",
            "Yesterday, 04:45 PM");

            dgvActivities.Rows.Add(
            "Nimali deposited Rs 2,500 to central fund",
            "Yesterday, 02:20 PM");
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MembersForm frm = new MembersForm();

            frm.Show();

            this.Hide();
        }

        
        private void button14_Click_1(object sender, EventArgs e)
        {

            MembersForm frm = new MembersForm();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CentralFundForm frm = new CentralFundForm();
            frm.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            frm.Show();
            this.Hide();
        }
    }
}
