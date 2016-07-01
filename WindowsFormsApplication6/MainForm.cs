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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;//去掉窗体的外框
            this.StartPosition = FormStartPosition.CenterScreen;//设置窗体居屏幕中央
        }

        private void skinCaptionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 购买手机ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void skinButton6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 修改用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Phone_buying f2 = new Phone_buying();
            f2.ShowDialog();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Phone_researching f2 = new Phone_researching();
            f2.ShowDialog();
        }

        private void skinMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            Revise_info f2 = new Revise_info();
            f2.ShowDialog();
        }
    }
}
