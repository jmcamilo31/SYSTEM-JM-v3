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
    public partial class ucApplicant : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";

        public ucApplicant()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucAppAddEdit.Dock = DockStyle.Fill;
            ucAppAddEdit.Visible = true;
            ucAppAddEdit.panel1.Visible = true;
            ucAppAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucAppAddEdit.Dock = DockStyle.Fill;
            ucAppAddEdit.Visible = true;
            ucAppAddEdit.panel1.Visible = false;
            ucAppAddEdit.panel2.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ucAppView.Dock = DockStyle.Fill;
            ucAppView.Visible = true;
        }

        private void ucAppAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Findstaff.Connection();
            connection = con.dbConnection();
            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', apps.app_no'Active Application', job.jobname'Applying for' "
                    + "from app_t app join applications_t apps "
                    + "on app.app_id = apps.app_id "
                    + "join job_t job "
                    + "on apps.job_id = job.job_id "
                    + "where apps.appstats = 'Active';";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvApplicant.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
