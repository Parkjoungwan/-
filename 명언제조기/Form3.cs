using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 명언제조기
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader(@"data\text1.txt", System.Text.Encoding.Default);
            string[] sb = new string[20];
            int i = 0;
            foreach (string s in reader.ReadToEnd().Split('\n'))

            {
                sb[i] = s.Replace("\r", "");
                i++;
                if (i == 20) break;
            }
            for (int j = 0; j < i;j++)
            {
                listBox1.Items.Add(sb[j]);
            }
            StreamReader reader2 = new StreamReader(@"data\text2.txt", System.Text.Encoding.Default);
            int k = 0;
            string[] sb2 = new string[20];
            foreach (string s in reader2.ReadToEnd().Split('\n'))
            {
                sb2[k] = s.Replace("\r", "");
                k++;
                if (k == 20) break;
            }
            for (int j = 0; j < k; j++)
            {
                listBox2.Items.Add(sb2[j]);
            }
            reader.Close();
            reader2.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
