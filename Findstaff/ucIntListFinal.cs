﻿using System;
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
    public partial class ucIntListFinal : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucIntListFinal()
        {
            InitializeComponent();
        }

        private void ucIntListFinal_Load(object sender, EventArgs e)
        {
            string jname = "", jorder = "", emp = "";

            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string query = "SELECT * FROM EMP_T;";
            com = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                //jname = dataReader.GetString();
                //jorder = dataReader.GetString();
                //emp = dataReader.GetString();
            }
            connection.Close();

            jobname.Text = jname;
            joborder.Text = jorder;
            employer.Text = emp;
        }

        private void btnPassInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Passed!", "Passed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFailInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Failed!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
