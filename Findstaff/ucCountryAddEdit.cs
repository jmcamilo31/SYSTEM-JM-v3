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
    public partial class ucCountryAddEdit : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        MySqlCommand com = new MySqlCommand();

        public ucCountryAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            string cID = "";
            string cou = "select count(*) from country_t;";
            MySqlCommand com = new MySqlCommand(cou, connection);
            ctr = int.Parse(com.ExecuteScalar() + "");
            if ((ctr + "").Length == 1)
            {
                cID = "C0000" + ctr + "";
            }
            else if ((ctr + "").Length == 2)
            {
                cID = "C000" + ctr + "";
            }
            else if ((ctr + "").Length == 3)
            {
                cID = "C00" + ctr + "";
            }
            else if ((ctr + "").Length == 4)
            {
                cID = "C0" + ctr + "";
            }
            else if ((ctr + "").Length == 5)
            {
                cID = "C" + ctr + "";
            }
            else
            {
                MessageBox.Show("Table in the database will not be able to handle more records.");
            }
            if (cID != "")
            {
                string check = "Select Count(Countryname) from Country_t where Countryname = '" + txtCountryName1.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    string cmd = "Insert into Country_t (Country_id, countryname) values ('" + cID + "','" + txtCountryName1.Text + "')";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCountryName1.Clear();
                    this.Hide();
                }
                else if (ctr != 0)
                {
                    MessageBox.Show("Record already exists.", "Error Message");
                }
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucCountryAddEdit_Load(object sender, EventArgs e)
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

        private void cbReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucCountryAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                connection.Open();
                string cmd = "select reqname from genreqs_t where allocation = 'country';";
                com = new MySqlCommand(cmd, connection);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbReq.Items.Add(dr[0].ToString());
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbReq.Items.Clear();
            }
        }
    }
}
