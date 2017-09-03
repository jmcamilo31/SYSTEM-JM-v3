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
using MySql.Data.MySqlClient;

namespace Findstaff
{
    public partial class fMain : Form
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter;
        private string cmd = "";

        public fMain()
        {
            InitializeComponent();
            ucJobOrderManagement.Dock = DockStyle.Fill;
            ucRecruitment.Dock = DockStyle.Fill;
            ucDocumentation.Dock = DockStyle.Fill;
            ucAcco.Dock = DockStyle.Fill;
            ucMaintenance.Dock = DockStyle.Fill;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string lname = "", fname = "", mname = "", deptname = "";

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string query = "SELECT * FROM EMP_T;";
            com = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                lname = dataReader.GetString(3);
                fname = dataReader.GetString(4);
                mname = dataReader.GetString(5);
                deptname = dataReader.GetString(10);
            }
            connection.Close();

            lblName.Text = (fname + mname + lname);
            lblDept.Text = deptname;
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

        private void rbJobOrderManagement_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = true;
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = false;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;
        }

        private void rbRecruitment_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
            ucRecruitment.Visible = true;
            ucDocumentation.Visible = false;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;
        }

        private void rbDocumentation_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = true;
            ucAcco.Visible = false;
            ucMaintenance.Visible = false;

            connection.Open();
            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', count(ad.req_id)'No. of Documents to be passed' "
                    + "from app_t app join appdoc_t ad "
                    + "on app.app_id = ad.app_id ";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucDocumentation.dgvDocumentation.DataSource = ds.Tables[0];
                }
            }
            connection.Close();
        }

        private void rbAcco_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
            ucRecruitment.Visible = false;
            ucDocumentation.Visible = false;
            ucAcco.Visible = true;
            ucMaintenance.Visible = false;
        }

        private void rbMaintenance_CheckedChanged(object sender, EventArgs e)
        {
            ucJobOrderManagement.Visible = false;
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
