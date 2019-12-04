using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace 명언제조기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void 텍스트추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FilePath = @"data";
            Process.Start(FilePath);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 사진추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FilePath = @"resultpic";
            Process.Start(FilePath);
        }

        private void 텍스트추가도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"data\help.txt");
        }
    }
}
