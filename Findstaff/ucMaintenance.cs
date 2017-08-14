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
    public partial class ucMaintenance : UserControl
    {
        public ucMaintenance()
        {
            InitializeComponent();
            ucEmployee.Dock = DockStyle.Fill;
            ucApplicant.Dock = DockStyle.Fill;
            ucCountry.Dock = DockStyle.Fill;
            ucEmployer.Dock = DockStyle.Fill;
            ucJobOrder.Dock = DockStyle.Fill;
            ucJobList.Dock = DockStyle.Fill;
            ucJobFees.Dock = DockStyle.Fill;
            ucGenReqs.Dock = DockStyle.Fill;
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = true;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
        }

        private void rbApplicant_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = true;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
        }

        private void rbCountry_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = true;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
        }

        private void rbEmployer_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = true;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
        }

        private void rbJobOrder_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = true;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
        }

        private void rbJob_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = true;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
        }

        private void rbFees_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = true;
            ucGenReqs.Visible = false;
        }

        private void rbGeneralRequirements_CheckedChanged(object sender, EventArgs e)
        {
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = true;
        }
    }
}
