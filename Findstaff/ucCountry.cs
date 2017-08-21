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
    public partial class ucCountry : UserControl
    {
        private MySqlConnection connection;
        MySqlCommand com = new MySqlCommand();

        public ucCountry()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucCountryAddEdit.Dock = DockStyle.Fill;
            ucCountryAddEdit.Visible = true;
            ucCountryAddEdit.panel1.Visible = true;
            ucCountryAddEdit.panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ucCountryAddEdit.Dock = DockStyle.Fill;
            ucCountryAddEdit.Visible = true;
            ucCountryAddEdit.panel1.Visible = false;
            ucCountryAddEdit.panel2.Visible = true;
        }

        private void ucCountryAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            string com = "Select country_id 'Country Id', countryname 'Country Name' from Country_t";
            using (connection)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(com, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvCountry.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            connection = con.dbConnection();
            connection.Open();
            string cmd = "delete from country_t where country_id = '" + dgvCountry.SelectedRows[0].Cells[0].Value.ToString() + "';";
            com = new MySqlCommand(cmd, connection);
            com.ExecuteNonQuery();
            dgvCountry.Rows.Remove(dgvCountry.SelectedRows[0]);
            MessageBox.Show("Country Deleted!", "Coutry Record Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }
    }
}
