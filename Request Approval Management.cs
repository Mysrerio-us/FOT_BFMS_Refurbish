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
    public partial class RequestApprovalForm : Form
    {
        public RequestApprovalForm()
        {
            InitializeComponent();
        }

        private void RequestApprovalForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Cells["Status"].Value = "Approved";
                MessageBox.Show("Request Approved!");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Cells["Status"].Value = "Rejected";
                MessageBox.Show("Request Rejected!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard frm =
       new AdminDashboard();

            frm.Show();

            this.Close();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
