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
    public partial class ucIntListFinal : UserControl
    {
        public ucIntListFinal()
        {
            InitializeComponent();
        }

        private void btnPassInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Passed!", "Passed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnFailInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Failed!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
