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
    public partial class ucEmployeeView : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucEmployeeView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucEmployeeView_Load(object sender, EventArgs e)
        {
            string empId = "",
                uname = "",
                lname = "",
                fname = "",
                mname = "",
                gnder = "",
                birthdate = "",
                add = "",
                contact = "",
                deptname = "";

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string query = "SELECT * FROM EMP_T;";
            com = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                empId = dataReader.GetString(0);
                uname = dataReader.GetString(1);
                lname = dataReader.GetString(3);
                fname = dataReader.GetString(4);
                mname = dataReader.GetString(5);
                gnder = dataReader.GetString(6);
                birthdate = dataReader.GetString(7);
                add = dataReader.GetString(8);
                contact = dataReader.GetString(9);
                deptname = dataReader.GetString(10);
            }
            connection.Close();

            empID.Text = empId;
            username.Text = uname;
            name.Text = (fname +" "+ mname +" "+ lname);
            gender.Text = gnder;
            bday.Text = birthdate;
            address.Text = add;
            contactNum.Text = contact;
            dept.Text = deptname;
        }
    }
}
