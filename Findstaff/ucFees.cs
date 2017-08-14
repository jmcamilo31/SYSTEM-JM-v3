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
    public partial class ucFees : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public string Fee_ID;
        public string Feename;

        public ucFees()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucFeesAddEdit.Dock = DockStyle.Fill;
            ucFeesAddEdit.Visible = true;
            ucFeesAddEdit.panel1.Visible = true;
            ucFeesAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucFeesAddEdit.Dock = DockStyle.Fill;
            ucFeesAddEdit.Visible = true;
            ucFeesAddEdit.panel1.Visible = false;
            ucFeesAddEdit.panel2.Visible = true;
            ucFeesAddEdit.txtID.Text = dgvFees.SelectedRows[0].Cells[0].Value.ToString();
            ucFeesAddEdit.txtName.Text = dgvFees.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ucFees_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "rms";
            uid = "root";
            password = "anterograde";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            string com = "Select Fee_ID'Fee ID', Feename'Fee Name' from Genfees_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvFees.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
