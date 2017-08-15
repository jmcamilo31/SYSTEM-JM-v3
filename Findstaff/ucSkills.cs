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
    public partial class ucSkills : UserControl
    {
        public ucSkills()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucSkillsAddEdit.Dock = DockStyle.Fill;
            ucSkillsAddEdit.Visible = true;
            ucSkillsAddEdit.panel1.Visible = true;
            ucSkillsAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvSkills.Rows.Count != 0)
            {
                ucSkillsAddEdit.Dock = DockStyle.Fill;
                ucSkillsAddEdit.Visible = true;
                ucSkillsAddEdit.panel1.Visible = false;
                ucSkillsAddEdit.panel2.Visible = true;
                ucSkillsAddEdit.txtSkillID.Text = dgvSkills.SelectedRows[0].Cells[0].Value.ToString();
                ucSkillsAddEdit.txtSkillName2.Text = dgvSkills.SelectedRows[0].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("No record available for edit.", "No Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
