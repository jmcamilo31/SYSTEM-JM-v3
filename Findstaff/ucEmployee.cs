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
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private string cmd = "";

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
            cmd = "select username'Username', Concat(fname , ' ' , lname)'Employee Name', DEPTNAME'Department' from Emp_t;";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvEmployee.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
