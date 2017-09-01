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
    public partial class ucInterviewInit : UserControl
    {
        public ucInterviewInit()
        {
            InitializeComponent();
        }

        private void btnViewIntList_Click(object sender, EventArgs e)
        {
            ucIntListInit.Dock = DockStyle.Fill;
            ucIntListInit.Visible = true;
        }
    }
}
