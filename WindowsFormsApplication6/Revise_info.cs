using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Revise_info : Form
    {
        public Revise_info()
        {
            InitializeComponent();
        }

        private void skinMonthCalendar1_Load(object sender, EventArgs e)
        {
                    }

        private void skinLabel1_Click(object sender, EventArgs e)
        {

        }

        private void skinLabel2_Click(object sender, EventArgs e)
        {

        }

        private void skinLabel4_Click(object sender, EventArgs e)
        {

        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            revise_success f2 = new revise_success();
            f2.ShowDialog();
        }
    }
}
