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
    public partial class ucJobOrderAddEdit : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;

        public ucJobOrderAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            if (txtJobNo.Text != "")
            {
                if (cbEmployer.SelectedIndex != -1)
                {
                    string empid = "", getID = "select employer_id from employer_t where employername = '" + cbEmployer.Text + "';";
                    com = new MySqlCommand(getID, connection);
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        empid = dr[0].ToString();
                    }
                    dr.Close();
                    string check = "Select Count(jorder_id) from joborder_t where jorder_id = '" + txtJobNo.Text + "'";
                    com = new MySqlCommand(check, connection);
                    ctr = int.Parse(com.ExecuteScalar() + "");
                    if (ctr == 0)
                    {
                        string cmd = "Insert into joborder_t (Jorder_id, employer_id, cntrctstart, cntrctend, cntrctstat) values ('" + txtJobNo.Text + "','" + empid + "','" + cbContractYear.Text + "-" + cbContractMonth.SelectedIndex+1 + "-" + cbContractDay.Text + "','" + (Convert.ToUInt32(cbContractYear.Text)+4).ToString() + "-" + cbContractMonth.SelectedIndex + 1 + "-" + cbContractDay.Text + "', 'Active')";
                        com = new MySqlCommand(cmd, connection);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtJobNo.Clear();
                        this.Hide();
                    }
                    else if (ctr != 0)
                    {
                        MessageBox.Show("Record already exists.", "Error Message");
                    }
                }
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucJobOrderAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();

            if (this.Visible == true)
            {
                connection.Open();
                string cmd = "Select employername from employer_t;";
                com = new MySqlCommand(cmd, connection);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbEmployer.Items.Add(dr[0].ToString());
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbEmployer.Items.Clear();
            }
        }
    }
}
