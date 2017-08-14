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
            ucSkillsAddEdit.Dock = DockStyle.Fill;
            ucSkillsAddEdit.Visible = true;
            ucSkillsAddEdit.panel1.Visible = false;
            ucSkillsAddEdit.panel2.Visible = true;
        }
    }
}
