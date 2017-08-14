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
    public partial class ucEmployer : UserControl
    {
        public ucEmployer()
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
            ucEmployerAddEdit.Dock = DockStyle.Fill;
            ucEmployerAddEdit.Visible = true;
            ucEmployerAddEdit.panel1.Visible = true;
            ucEmployerAddEdit.panel2.Visible = false;
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            ucEmployerAddEdit.Dock = DockStyle.Fill;
            ucEmployerAddEdit.Visible = true;
            ucEmployerAddEdit.panel1.Visible = false;
            ucEmployerAddEdit.panel2.Visible = true;
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            ucEmployerView.Dock = DockStyle.Fill;
            ucEmployerView.Visible = true;
        }

        private void ucEmployer_Load(object sender, EventArgs e)
        {

        }
    }
}
