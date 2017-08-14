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
    public partial class ucJobOrder : UserControl
    {
        public ucJobOrder()
        {
            InitializeComponent();
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobOrderAddEdit.Dock = DockStyle.Fill;
            ucJobOrderAddEdit.Visible = true;
            ucJobOrderAddEdit.panel1.Visible = true;
            ucJobOrderAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucJobOrderAddEdit.Dock = DockStyle.Fill;
            ucJobOrderAddEdit.Visible = true;
            ucJobOrderAddEdit.panel1.Visible = false;
            ucJobOrderAddEdit.panel2.Visible = true;
        }
    }
}
