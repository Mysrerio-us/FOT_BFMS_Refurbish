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
            txtRequestID.Text = "REQ001";
            txtMemberName.Text = "SK";
            txtRequestType.Text = "Withdraw";
            txtAmount.Text = "3000";
            txtRequestDate.Text = "12/06/2026";
            txtReason.Text = "Batch Event Expenses";
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Approved");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Rejected");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard frm =
       new AdminDashboard();

            frm.Show();

            this.Close();
        }
    }
}
