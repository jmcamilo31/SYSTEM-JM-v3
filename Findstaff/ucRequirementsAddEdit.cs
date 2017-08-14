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
    public partial class ucRequirementsAddEdit : UserControl
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public ucRequirementsAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (txtRequirement.Text != "")
            {
                int ctr = 0;
                string cID = "";
                string cou = "select count(*) from genreqs_t;";
                MySqlCommand com = new MySqlCommand(cou, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if ((ctr + "").Length == 1)
                {
                    cID = "R0000" + ctr + "";
                }
                else if ((ctr + "").Length == 2)
                {
                    cID = "R000" + ctr + "";
                }
                else if ((ctr + "").Length == 3)
                {
                    cID = "R00" + ctr + "";
                }
                else if ((ctr + "").Length == 4)
                {
                    cID = "R0" + ctr + "";
                }
                else if ((ctr + "").Length == 5)
                {
                    cID = "R" + ctr + "";
                }
                else
                {
                    MessageBox.Show("Table in the database will not be able to handle more records.");
                }
                if (cID != "")
                {
                    string check = "Select Count(reqname) from Genreqs_t where reqname = '" + txtRequirement.Text + "'";
                    com = new MySqlCommand(check, connection);
                    ctr = int.Parse(com.ExecuteScalar() + "");
                    if (ctr == 0)
                    {
                        if (cbDesignation.SelectedIndex != -1)
                        {
                            string cmd = "Insert into Genreqs_t (Req_id, reqname, allocation) values ('" + cID + "','" + txtRequirement.Text + "','" + cbDesignation.Text + "')";
                            com = new MySqlCommand(cmd, connection);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Requirement Record Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtRequirement.Clear();
                            cbDesignation.SelectedIndex = -1;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No Requirement Designation", "Error Message");
                        }
                    }
                    else if (ctr != 0)
                    {
                        MessageBox.Show("Record already exists.", "Error Message");
                    }
                }
            }
            else
            {
                MessageBox.Show("Requirement Name Field Empty", "Error Message");
            }
            connection.Close();
        }
        
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtRequirement.Clear();
            cbDesignation.SelectedIndex = -1;
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            txtRequirement.Clear();
            this.Hide();
        }

        private void ucRequirementsAddEdit_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "rms";
            uid = "root";
            password = "anterograde";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
    }
}
