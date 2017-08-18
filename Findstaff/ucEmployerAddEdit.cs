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
    public partial class ucEmployerAddEdit : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        MySqlCommand com = new MySqlCommand();

        public ucEmployerAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            string cID = "";
            string cou = "select count(*) from employer_t;";
            MySqlCommand com = new MySqlCommand(cou, connection);
            ctr = int.Parse(com.ExecuteScalar() + "");
            if ((ctr + "").Length == 1)
            {
                cID = "E0000" + ctr + "";
            }
            else if ((ctr + "").Length == 2)
            {
                cID = "E000" + ctr + "";
            }
            else if ((ctr + "").Length == 3)
            {
                cID = "E00" + ctr + "";
            }
            else if ((ctr + "").Length == 4)
            {
                cID = "E0" + ctr + "";
            }
            else if ((ctr + "").Length == 5)
            {
                cID = "E" + ctr + "";
            }
            else
            {
                MessageBox.Show("Table in the database will not be able to handle more records.");
            }
            if (cID != "")
            {
                string check = "Select Count(Employername) from employer_t where Employername = '" + txtEmp1.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    string cmd1 = "Select country_id from country_t where countryname = '"+cbCountry1.Text+"'", countID = "";
                    com = new MySqlCommand(cmd1, connection);
                    MySqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        countID = dr[0].ToString();
                    }
                    dr.Close();
                    string cmd = "Insert into Employer_t (Employer_id, employername, foreignprin, country_id) values ('" + cID + "','" + txtEmp1.Text + "','"+txtPrincipal1.Text+"','"+countID+"')";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmp1.Clear();
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

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucEmployerAddEdit_Load(object sender, EventArgs e)
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

        private void ucEmployerAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                connection.Open();
                string cmd = "select countryname from country_t;";
                com = new MySqlCommand(cmd, connection);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbCountry1.Items.Add(dr[0].ToString());
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbCountry1.Items.Clear();
            }
        }
    }
    
}
