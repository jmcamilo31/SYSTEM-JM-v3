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
    public partial class ucSkills : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucSkills()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucSkillsAddEdit.Dock = DockStyle.Fill;
            ucSkillsAddEdit.Visible = true;
            ucSkillsAddEdit.panel1.Visible = true;
            ucSkillsAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvSkills.Rows.Count != 0)
            {
                ucSkillsAddEdit.Dock = DockStyle.Fill;
                ucSkillsAddEdit.Visible = true;
                ucSkillsAddEdit.panel1.Visible = false;
                ucSkillsAddEdit.panel2.Visible = true;
                ucSkillsAddEdit.txtSkillID.Text = dgvSkills.SelectedRows[0].Cells[0].Value.ToString();
                ucSkillsAddEdit.txtSkillName2.Text = dgvSkills.SelectedRows[0].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("No record available for edit.", "No Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from genskills_t where skill_id = '" + dgvSkills.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvSkills.Rows.Remove(dgvSkills.SelectedRows[0]);
            MessageBox.Show("Skills Deleted!", "Skills Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void ucSkillsAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select skill_id 'Skill Id', skillname 'Skill Name' from Genskills_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvSkills.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
