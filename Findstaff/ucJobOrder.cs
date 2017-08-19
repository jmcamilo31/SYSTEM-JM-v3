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
    public partial class ucJobOrder : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        MySqlCommand com = new MySqlCommand();

        public ucJobOrder()
        {
            InitializeComponent();
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucJobOrderAddEdit.Dock = DockStyle.Fill;
            ucJobOrderAddEdit.Visible = true;
            ucJobOrderAddEdit.panel1.Visible = true;
            ucJobOrderAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucJobOrderAddEdit.Dock = DockStyle.Fill;
            ucJobOrderAddEdit.Visible = true;
            ucJobOrderAddEdit.panel1.Visible = false;
            ucJobOrderAddEdit.panel2.Visible = true;
        }

        private void ucJobOrder_Load(object sender, EventArgs e)
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

        private void ucJobOrder_VisibleChanged(object sender, EventArgs e)
        {
       
        }
    }
}
