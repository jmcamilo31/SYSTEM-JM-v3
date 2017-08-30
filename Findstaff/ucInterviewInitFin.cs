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
    public partial class ucInterviewInitFin : UserControl
    {
        public ucInterviewInitFin()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
        }

        private void btnViewIntList1_Click(object sender, EventArgs e)
        {
            ucIntListInit.Dock = DockStyle.Fill;
            ucIntListInit.Visible = true;
        }

        private void btnViewIntList2_Click(object sender, EventArgs e)
        {
            ucIntListFinal.Dock = DockStyle.Fill;
            ucIntListFinal.Visible = true;
        }
    }
}
