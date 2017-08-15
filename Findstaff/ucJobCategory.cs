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
    public partial class ucJobCategory : UserControl
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public ucJobCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobCategoryAddEdit.Dock = DockStyle.Fill;
            ucJobCategoryAddEdit.Visible = true;
            ucJobCategoryAddEdit.panel1.Visible = true;
            ucJobCategoryAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvJobCategory.Rows.Count != 0)
            {
                ucJobCategoryAddEdit.Dock = DockStyle.Fill;
                ucJobCategoryAddEdit.Visible = true;
                ucJobCategoryAddEdit.panel1.Visible = false;
                ucJobCategoryAddEdit.panel2.Visible = true;
                ucJobCategoryAddEdit.txtID.Text = dgvJobCategory.SelectedRows[0].Cells[0].Value.ToString();
                ucJobCategoryAddEdit.txtName.Text = dgvJobCategory.SelectedRows[0].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("No record available for edit","No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucJobCategory_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "rms";
            uid = "root";
            password = "anterograde";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            string com = "Select category_ID'Category ID', categoryname'Category Name' from jobcategory_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvJobCategory.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
