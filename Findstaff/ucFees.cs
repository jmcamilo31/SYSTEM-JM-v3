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
        MySqlCommand com = new MySqlCommand();

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
            if(dgvFees.Rows.Count != 0)
            {
                ucFeesAddEdit.Dock = DockStyle.Fill;
                ucFeesAddEdit.Visible = true;
                ucFeesAddEdit.panel1.Visible = false;
                ucFeesAddEdit.panel2.Visible = true;
                ucFeesAddEdit.txtID.Text = dgvFees.SelectedRows[0].Cells[0].Value.ToString();
                ucFeesAddEdit.txtName.Text = dgvFees.SelectedRows[0].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("No record available for edit.","No Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFeesAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from genfees_t where fee_id = '" + dgvFees.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvFees.Rows.Remove(dgvFees.SelectedRows[0]);
            MessageBox.Show("Fee Deleted!", "Fee Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }
    }
}
