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
    public partial class ucDocAppDetails : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucDocAppDetails()
        {
            InitializeComponent();
        }

        private void ucDocAppDetails_Load(object sender, EventArgs e)
        {
            string app = "", jname = "", jorder = "", emp = "";

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string query = "SELECT * FROM EMP_T;";
            com = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                //app = dataReader.GetString();
                //jname = dataReader.GetString();
                //jorder = dataReader.GetString();
                //emp = dataReader.GetString();
            }
            connection.Close();

            applicant.Text = app;
            jobname.Text = jname;
            joborder.Text = jorder;
            employer.Text = emp;
        }

        private void btnMoveToAcco_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
