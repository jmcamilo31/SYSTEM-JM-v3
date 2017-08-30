using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Findstaff
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            ucRecruitment.Dock = DockStyle.Fill;
            ucDocumentation.Dock = DockStyle.Fill;
            ucAcco.Dock = DockStyle.Fill;
            ucMaintenance.Dock = DockStyle.Fill;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult y = MessageBox.Show("Are you sure you want to logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == y)
            {
                Login l = new Login();
                l.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void rbRecruitment_CheckedChanged(object sender, EventArgs e)
        {
            ucRecruitment.Visible = true;
            ucDocumentation.Visible = false;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;
        }

        private void rbDocumentation_CheckedChanged(object sender, EventArgs e)
        {
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = true;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;
        }

        private void rbAcco_CheckedChanged(object sender, EventArgs e)
        {
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = false;
            ucAcco.Visible = true;
            ucMaintenance.Visible = false;
        }

        private void rbMaintenance_CheckedChanged(object sender, EventArgs e)
        {
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = false;
            ucAcco.Visible = false;
            ucMaintenance.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
