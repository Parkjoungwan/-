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

namespace 명언제조기
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String add = textBox1.Text;

            try
            {
                File.AppendAllText(@"data\text2.txt", add+"\n", Encoding.Default);
            }
            catch
            {
                MessageBox.Show("추가 실패.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }
    }
}
