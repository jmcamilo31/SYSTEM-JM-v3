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
    public partial class ucRequirements : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public ucRequirements()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucRequirementsAddEdit.Dock = DockStyle.Fill;
            ucRequirementsAddEdit.Visible = true;
            ucRequirementsAddEdit.panel1.Visible = true;
            ucRequirementsAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucRequirementsAddEdit.Dock = DockStyle.Fill;
            ucRequirementsAddEdit.Visible = true;
            ucRequirementsAddEdit.panel1.Visible = false;
            ucRequirementsAddEdit.panel2.Visible = true;
        }

        private void ucRequirements_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "rms";
            uid = "root";
            password = "anterograde";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            string com = "Select Req_ID'Requirement ID', reqname'Requirement Name', Allocation from Genreqs_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvRequirements.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
