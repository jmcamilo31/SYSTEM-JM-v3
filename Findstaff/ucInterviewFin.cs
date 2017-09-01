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
    public partial class ucInterviewFin : UserControl
    {
        public ucInterviewFin()
        {
            InitializeComponent();
        }

        private void btnViewIntList_Click(object sender, EventArgs e)
        {
            ucIntListFinal.Dock = DockStyle.Fill;
            ucIntListFinal.Visible = true;
        }
    }
}
