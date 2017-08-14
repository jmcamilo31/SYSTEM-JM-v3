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
    public partial class ucEmployee : UserControl
    {
        public ucEmployee()
        {
            InitializeComponent();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            ucEmployeeAddEdit.Dock = DockStyle.Fill;
            ucEmployeeAddEdit.Visible = true;
            ucEmployeeAddEdit.panel1.Visible = true;
            ucEmployeeAddEdit.panel2.Visible = false;
        }

        private void btnEmpUpd_Click(object sender, EventArgs e)
        {
            ucEmployeeAddEdit.Dock = DockStyle.Fill;
            ucEmployeeAddEdit.Visible = true;
            ucEmployeeAddEdit.panel1.Visible = false;
            ucEmployeeAddEdit.panel2.Visible = true;
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            ucEmployeeView.Dock = DockStyle.Fill;
            ucEmployeeView.Visible = true;
        }
    }
}
