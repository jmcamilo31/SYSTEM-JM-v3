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
    public partial class ucGenReqs : UserControl
    {
        public ucGenReqs()
        {
            InitializeComponent();
            ucFees.Dock = DockStyle.Fill;
            ucJobCategory.Dock = DockStyle.Fill;
            ucSkills.Dock = DockStyle.Fill;
            ucRequirements.Dock = DockStyle.Fill;
            ucJobs.Dock = DockStyle.Fill;
        }

        private void rbFees_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = true;
            ucJobCategory.Visible = false;
            ucSkills.Visible = false;
            ucRequirements.Visible = false;
            ucJobs.Visible = false;
        }

        private void rbJobCategory_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = false;
            ucJobCategory.Visible = true;
            ucSkills.Visible = false;
            ucRequirements.Visible = false;
            ucJobs.Visible = false;
        }

        private void rbSkills_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = false;
            ucJobCategory.Visible = false;
            ucSkills.Visible = true;
            ucRequirements.Visible = false;
            ucJobs.Visible = false;
        }

        private void rbRequirements_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = false;
            ucJobCategory.Visible = false;
            ucSkills.Visible = false;
            ucRequirements.Visible = true;
            ucJobs.Visible = false;
        }

        private void rbJobs_CheckedChanged(object sender, EventArgs e)
        {
            ucFees.Visible = false;
            ucJobCategory.Visible = false;
            ucSkills.Visible = false;
            ucRequirements.Visible = false;
            ucJobs.Visible = true;
        }
    }
}
