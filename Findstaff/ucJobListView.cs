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
    public partial class ucJobListView : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucJobListView()
        {
            InitializeComponent();
        }

        private void ucJobListView_Load(object sender, EventArgs e)
        {
            string emp = "",
                ctgry = "",
                jname = "",
                hght = "",
                wght = "",
                intdate = "",
                condate = "",
                empreq = "",
                slry = "";

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string query = "";
            com = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                //emp = dataReader.GetString();
                //ctgry = dataReader.GetString();
                //jname = dataReader.GetString();
                //empreq = dataReader.GetInt16();
                //slry = dataReader.GetInt16();
                //hght = dataReader.GetString();
                //wght = dataReader.GetString();
                //intdate = dataReader.GetString();
                //condate = dataReader.GetString();
            }
            connection.Close();

            employer.Text = emp;
            category.Text = ctgry;
            jobname.Text = jname;
            noofempreq.Text = empreq;
            salary.Text = slry;
            height.Text = hght;
            weight.Text = wght;
            interdate.Text = intdate;
            contractdate.Text = condate;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
