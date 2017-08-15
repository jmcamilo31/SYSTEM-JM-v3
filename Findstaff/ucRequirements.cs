using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Findstaff
{
    public partial class ucRequirements : UserControl
    {
        public ucRequirements()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucRequirementsAddEdit.Dock = DockStyle.Fill;
            ucRequirementsAddEdit.Visible = true;
            ucRequirementsAddEdit.panel1.Visible = true;
            ucRequirementsAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRequirements.Rows.Count != 0)
            {
                ucRequirementsAddEdit.Dock = DockStyle.Fill;
                ucRequirementsAddEdit.Visible = true;
                ucRequirementsAddEdit.panel1.Visible = false;
                ucRequirementsAddEdit.panel2.Visible = true;
                ucRequirementsAddEdit.txtRequirementID.Text = dgvRequirements.SelectedRows[0].Cells[0].Value.ToString();
                ucRequirementsAddEdit.txtRequirement2.Text = dgvRequirements.SelectedRows[0].Cells[1].Value.ToString();
                ucRequirementsAddEdit.cbDesignation1.Text = dgvRequirements.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("No record available for edit.", "No Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
