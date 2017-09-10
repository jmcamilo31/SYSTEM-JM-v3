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
    public partial class ucEmployee : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucEmployee()
        {
            InitializeComponent();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            ucEmployeeAddEdit.Dock = DockStyle.Fill;
            ucEmployeeAddEdit.Visible = true;
            ucEmployeeAddEdit.panel1.Visible = true;
            ucEmployeeAddEdit.panel2.Visible = false;
        }

        private void btnEmpUpd_Click(object sender, EventArgs e)
        {
            ucEmployeeAddEdit.Dock = DockStyle.Fill;
            ucEmployeeAddEdit.Visible = true;
            ucEmployeeAddEdit.panel1.Visible = false;
            ucEmployeeAddEdit.panel2.Visible = true;
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from emp_t where username = '" + dgvEmployee.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvEmployee.Rows.Remove(dgvEmployee.SelectedRows[0]);
            MessageBox.Show("Employee Deleted!", "Employee Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            ucEmployeeView.Dock = DockStyle.Fill;
            ucEmployeeView.Visible = true;
        }

        private void ucEmployeeAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "select username'Username', Concat(fname , ' ' , lname)'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
