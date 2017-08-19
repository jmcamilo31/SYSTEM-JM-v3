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
        private string server;
        private string database;
        private string uid;
        private string password;

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
            dgvFees.DataSource = ucFeesAddEdit;
            dgvFees.Refresh();
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

        private void ucFees_Load(object sender, EventArgs e)
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
    }
}
