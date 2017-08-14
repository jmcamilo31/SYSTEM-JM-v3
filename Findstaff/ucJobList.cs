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
    public partial class ucJobList : UserControl
    {
        public ucJobList()
        {
            InitializeComponent();
        }

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            ucJobListAddEdit.Dock = DockStyle.Fill;
            ucJobListAddEdit.Visible = true;
            ucJobListAddEdit.panel1.Visible = true;
            ucJobListAddEdit.panel2.Visible = false;
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            ucJobListAddEdit.Dock = DockStyle.Fill;
            ucJobListAddEdit.Visible = true;
            ucJobListAddEdit.panel1.Visible = false;
            ucJobListAddEdit.panel2.Visible = true;
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            ucJobListView.Dock = DockStyle.Fill;
            ucJobListView.Visible = true;
        }
    }
}
