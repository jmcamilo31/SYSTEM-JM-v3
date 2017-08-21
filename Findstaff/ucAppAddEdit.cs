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
    public partial class ucAppAddEdit : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        private string cmd = "";

        public ucAppAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void cbSchoolType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSchoolType.SelectedIndex == 2)
            {
                txtDegree.Enabled = true;
            }
            else
            {
                txtDegree.Enabled = false;
            }
        }

        private void ucAppAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            if(this.Visible == true)
            {
                connection.Open();
                cmd = "Select jobname from job_t;";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbPosition.Items.Add(dr[0].ToString());
                }
                dr.Close();
                cmd = "Select skillname from Genskills_t;";
                com = new MySqlCommand(cmd, connection);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbSkills.Items.Add(dr[0].ToString());
                }
                dr.Close();
                connection.Close();
            }
            else
            {
                cbPosition.Items.Clear();
                cbSkills.Items.Clear();
            }
        }

        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            if(cbSkills.SelectedIndex != -1 && cbProficiency.SelectedIndex != -1)
            {
                dgvSkills.ColumnCount = 2;
                dgvSkills.Rows.Add(cbSkills.Text, cbProficiency.Text);
                cbSkills.Items.Remove(cbSkills.Text);
                cbSkills.SelectedIndex = -1;
                cbProficiency.SelectedIndex = -1;
            }
        }

        private void btnRemoveSkills_Click(object sender, EventArgs e)
        {
            if(dgvSkills.Rows.Count != 0)
            {
                cbSkills.Items.Add(dgvSkills.SelectedRows[0].Cells[0].Value.ToString());
                dgvSkills.Rows.Remove(dgvSkills.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Skills table has no data.","Remove Skills Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEduc_Click(object sender, EventArgs e)
        {
            if(txtSchoolName.Text != "" && cbSchoolType.Text != ""
                && txtYearStarted.Text != "" && txtYearEnded.Text != "")
            {
                dgvEducBack.ColumnCount = 5;
                dgvEducBack.Rows.Add(txtSchoolName.Text, cbSchoolType.Text, txtYearStarted.Text, txtYearEnded.Text, txtDegree.Text);
                txtSchoolName.Clear();
                cbSchoolType.SelectedIndex = -1;
                txtYearStarted.Clear();
                txtYearEnded.Clear();
                txtDegree.Clear();
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            txtLastName.Clear();
            txtLastName.ForeColor = Color.Black;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtFirstName.ForeColor = Color.Black;
        }

        private void txtMiddleName_Enter(object sender, EventArgs e)
        {
            txtMiddleName.Clear();
            txtMiddleName.ForeColor = Color.Black;
        }
    }
}
