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
            pnlAppList.Dock = DockStyle.Fill;
            pnlJobApp.Dock = DockStyle.Fill;
        }

        private void rbApplicantList_CheckedChanged(object sender, EventArgs e)
        {
            pnlAppList.Visible = true;
            pnlJobApp.Visible = false;
        }

        private void rbJobApplicant_CheckedChanged(object sender, EventArgs e)
        {
            pnlAppList.Visible = false;
            pnlJobApp.Visible = true;
        }

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ucAppView.Dock = DockStyle.Fill;
            ucAppView.Visible = true;
        }
    }
}
