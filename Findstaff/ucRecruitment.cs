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
    public partial class ucRecruitment : UserControl
    {
        public ucRecruitment()
        {
            InitializeComponent();
            ucAppList.Dock = DockStyle.Fill;
            ucJobApp.Dock = DockStyle.Fill;
            ucInterviewInitFin.Dock = DockStyle.Fill;
        }

        private void rbApplicantList_CheckedChanged(object sender, EventArgs e)
        {
            ucAppList.Visible = true;
            ucJobApp.Visible = false;
            ucInterviewInitFin.Visible = false;
        }

        private void rbJobApplicant_CheckedChanged(object sender, EventArgs e)
        {
            ucAppList.Visible = false;
            ucJobApp.Visible = true;
            ucInterviewInitFin.Visible = false;
        }
        
        private void rbInterview_CheckedChanged(object sender, EventArgs e)
        {
            ucAppList.Visible = false;
            ucJobApp.Visible = false;
            ucInterviewInitFin.Visible = true;
        }
    }
}
