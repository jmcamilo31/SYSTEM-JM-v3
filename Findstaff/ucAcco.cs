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
    public partial class ucAcco : UserControl
    {
        public ucAcco()
        {
            InitializeComponent();
        }

        private void btnAdvSe_Click(object sender, EventArgs e)
        {
            fAdvSearch fas = new fAdvSearch();
            fas.Show();
        }

        private void btnViewAcco_Click(object sender, EventArgs e)
        {
            ucAccoView.Dock = DockStyle.Fill;
            ucAccoView.Visible = true;
        }
    }
}