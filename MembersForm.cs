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

        }
    }
}
