using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Findstaff
{
    public partial class ucCountry : UserControl
    {
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
    }
}
