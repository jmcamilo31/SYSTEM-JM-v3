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
    public partial class ucSkillsAddEdit : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public ucSkillsAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            string cID = "";
            string cou = "select count(*) from genskills_t;";
            MySqlCommand com = new MySqlCommand(cou, connection);
            ctr = int.Parse(com.ExecuteScalar() + "");
            if ((ctr + "").Length == 1)
            {
                cID = "S0000" + ctr + "";
            }
            else if ((ctr + "").Length == 2)
            {
                cID = "S000" + ctr + "";
            }
            else if ((ctr + "").Length == 3)
            {
                cID = "S00" + ctr + "";
            }
            else if ((ctr + "").Length == 4)
            {
                cID = "S0" + ctr + "";
            }
            else if ((ctr + "").Length == 5)
            {
                cID = "S" + ctr + "";
            }
            else
            {
                MessageBox.Show("Table in the database will not be able to handle more records.");
            }
            if (cID != "")
            {
                string check = "Select Count(Skillname) from Genskills_t where Skillname = '" + txtSkillName1.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    string cmd = "Insert into Genskills_t (Skill_id, skillname) values ('" + cID + "','" + txtSkillName1.Text + "')";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSkillName1.Clear();
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
            txtSkillName1.Clear();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
        
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucSkillsAddEdit_Load(object sender, EventArgs e)
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
