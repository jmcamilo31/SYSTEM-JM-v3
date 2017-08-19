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
    public partial class ucCountry : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        MySqlCommand com = new MySqlCommand();

        public ucCountry()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucCountryAddEdit.Dock = DockStyle.Fill;
            ucCountryAddEdit.Visible = true;
            ucCountryAddEdit.panel1.Visible = true;
            ucCountryAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucCountryAddEdit.Dock = DockStyle.Fill;
            ucCountryAddEdit.Visible = true;
            ucCountryAddEdit.panel1.Visible = false;
            ucCountryAddEdit.panel2.Visible = true;
        }

        private void ucCountry_Load(object sender, EventArgs e)
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

        private void ucCountryAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            string com = "Select country_id 'Country Id', countryname 'Country Name' from Country_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvCountry.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
