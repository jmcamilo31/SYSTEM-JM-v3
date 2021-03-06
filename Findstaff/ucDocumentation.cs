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
    public partial class ucDocumentation : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();
        MySqlDataAdapter adapter;
        private string cmd = "";

        public ucDocumentation()
        {
            InitializeComponent();
        }

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnCheckDetails_Click(object sender, EventArgs e)
        {
            ucDocAppDetails.Dock = DockStyle.Fill;
            ucDocAppDetails.Visible = true;
        }

        private void ucDocumentation_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            cmd = "select app.app_id'App ID', concat(app.lname, ', ', app.fname, ' ', app.mname)'Applicant Name', count(ad.req_id)'No. of Documents to be passed' "
                    + "from app_t app join appdoc_t ad "
                    + "on app.app_id = ad.app_id ";
            using (connection)
            {
                using (adapter = new MySqlDataAdapter(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvDocumentation.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
