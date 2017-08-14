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
    public partial class ucJobFees : UserControl
    {
        public ucJobFees()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobFeesAddEdit.Dock = DockStyle.Fill;
            ucJobFeesAddEdit.Visible = true;
            ucJobFeesAddEdit.panel1.Visible = true;
            ucJobFeesAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucJobFeesAddEdit.Dock = DockStyle.Fill;
            ucJobFeesAddEdit.Visible = true;
            ucJobFeesAddEdit.panel1.Visible = false;
            ucJobFeesAddEdit.panel2.Visible = true;
        }
    }
}
