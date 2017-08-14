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
    public partial class ucApplicant : UserControl
    {
        public ucApplicant()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucAppAddEdit.Dock = DockStyle.Fill;
            ucAppAddEdit.Visible = true;
            ucAppAddEdit.panel1.Visible = true;
            ucAppAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucAppAddEdit.Dock = DockStyle.Fill;
            ucAppAddEdit.Visible = true;
            ucAppAddEdit.panel1.Visible = false;
            ucAppAddEdit.panel2.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ucAppView.Dock = DockStyle.Fill;
            ucAppView.Visible = true;
        }
    }
}
