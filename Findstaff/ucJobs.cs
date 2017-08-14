using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Findstaff
{
    public partial class ucJobs : UserControl
    {
        public ucJobs()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobsAddEdit.Dock = DockStyle.Fill;
            ucJobsAddEdit.Visible = true;
            ucJobsAddEdit.panel1.Visible = true;
            ucJobsAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucJobsAddEdit.Dock = DockStyle.Fill;
            ucJobsAddEdit.Visible = true;
            ucJobsAddEdit.panel1.Visible = false;
            ucJobsAddEdit.panel2.Visible = true;
        }
    }
}
