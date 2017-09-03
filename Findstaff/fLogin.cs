using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Findstaff
{
    public partial class Login : Form
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult y = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == y)
            {
                Application.Exit();
            }
        }
        
        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Clear();
            txtUsername.ForeColor = Color.Black;
        }
        
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
            txtPassword.ForeColor = Color.Black;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = '❤';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain m = new fMain();
            m.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.DimGray;
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.PasswordChar = '\0';
        }
    }
}
