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
    public partial class ucMaintenance : UserControl
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlCommand com = new MySqlCommand();

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
            ucEmployee.Visible = false;
            ucApplicant.Visible = false;
            ucCountry.Visible = false;
            ucEmployer.Visible = false;
            ucJobOrder.Visible = false;
            ucJobList.Visible = false;
            ucJobFees.Visible = false;
            ucGenReqs.Visible = false;
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
            string com = "Select Emp_ID'Employee ID', Username'Username', fname+' '+lname'Employee Name' from Emp_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployee.dgvEmployee.DataSource = ds.Tables[0];
                }
            }
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
            string com = "Select COUNTRY_ID'Country ID', COUNTRYNAME'Country Name' from country_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucCountry.dgvCountry.DataSource = ds.Tables[0];
                }
            }
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
            string com = "Select EMPLOYER_ID'Employer ID', EMPLOYERNAME'Employer Name', FOREIGNPRIN'Foreign Principal' from employer_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucEmployer.dgvEmployer.DataSource = ds.Tables[0];
                }
            }
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

            string com = "Select jorder_id 'Job Order', employer_id 'Employer ID', cntrctstart 'Contract Start', cntrctend 'Contract End', cntrctstat 'Contract Status' from joborder_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ucJobOrder.dgvJobOrder.DataSource = ds.Tables[0];
                }
            }
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

        private void ucMaintenance_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "rms";
            uid = "root";
            //password = "anterograde";
            password = "rootpass";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
    }
}
