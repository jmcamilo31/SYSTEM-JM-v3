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
    public partial class ucFeesAddEdit : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlCommand com = new MySqlCommand();

        public ucFeesAddEdit()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            int ctr = 0;
            string cID = "";
            string cou = "select count(*) from genfees_t;";
            com = new MySqlCommand(cou, connection);
            ctr = int.Parse(com.ExecuteScalar()+"");
            if ((ctr+"").Length == 1)
            {
                cID = "F0000" + ctr + "";
            }
            else if ((ctr + "").Length == 2)
            {
                cID = "F000" + ctr + "";
            }
            else if ((ctr + "").Length == 3)
            {
                cID = "F00" + ctr + "";
            }
            else if ((ctr + "").Length == 4)
            {
                cID = "F0" + ctr + "";
            }
            else if ((ctr + "").Length == 5)
            {
                cID = "F" + ctr + "";
            }
            else
            {
                MessageBox.Show("Table in the database will not be able to handle more records.");
            }
            if(cID != "")
            {
                string check = "Select Count(Feename) from Genfees_t where Feename = '" + txtFees1.Text + "'";
                com = new MySqlCommand(check, connection);
                ctr = int.Parse(com.ExecuteScalar() + "");
                if (ctr == 0)
                {
                    string cmd = "Insert into Genfees_t (Fee_id, Feename) values ('" + cID + "','" + txtFees1.Text + "')";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFees1.Clear();
                    this.Hide();
                    
                }
                else if (ctr != 0)
                {
                    MessageBox.Show("Record already exists.", "Error Message");
                }
            }
            connection.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtFees1.Clear();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = "";
            if(txtName.Text == "")
            {
                MessageBox.Show("Fee name must not be empty.", "Empty Fee Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Are you sure You want to update the record with the following details?"
                    +"\nFee ID: "+txtID.Text+"\nNew Fee Name: "+txtName.Text, "Confirmation", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    cmd = "Update Genfees_t set feename = '" + txtName.Text + "' where fee_id = '" + txtID.Text + "';";
                    com = new MySqlCommand(cmd, connection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Changes Saved!", "Update Fee Record!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtName.Clear();
                    this.Hide();
                }
            }
            connection.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            this.Hide();
        }

        private void ucFeesAddEdit_Load(object sender, EventArgs e)
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
