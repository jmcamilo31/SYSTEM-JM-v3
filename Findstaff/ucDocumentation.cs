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
    public partial class ucDocumentation : UserControl
    {
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
    }
}
