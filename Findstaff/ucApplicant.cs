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
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from app_t where app_id = '" + dgvApplicant.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvApplicant.Rows.Remove(dgvApplicant.SelectedRows[0]);
            MessageBox.Show("Applicant Deleted!", "Applicant Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ucAppView.Dock = DockStyle.Fill;
            ucAppView.Visible = true;
        }

        private void ucAppAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', job.jobname'Applying for' "
                    + "from app_t app join job_t job "
                    + "on app.position = job.jobname ";
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
