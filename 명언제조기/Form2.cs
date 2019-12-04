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
using System.Drawing.Imaging;



namespace 명언제조기
{
    public partial class Form2 : Form
    {
        public Form2()
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
            StreamReader reader2 = new StreamReader(@"data\text2.txt", System.Text.Encoding.Default);
            int k = 0;
            string[] sb2 = new string[20];
            foreach (string s in reader2.ReadToEnd().Split('\n'))
            {
                sb2[k] = s.Replace("\r", "");
                k++;
                if (k == 20) break;
            }
 
            reader.Close();
            reader2.Close();
            Random r = new Random();
            int num1 = r.Next(0, i-1);
            int num2 = r.Next(0, k-1);
            label1.Text = sb[num1] + "은 " + sb[num1] + " 이요. " + sb2[num2] + "는 " + sb2[num2] + " 이니라.";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            PointF TextLocation = new PointF(67f, 32f);

            string imageFilePath = @"resultpic\image.bmp";
            Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font font = new Font("배달의민족 을지로체 TTF", 17))
                {
                    graphics.DrawString(label1.Text, font, Brushes.Black, TextLocation);
                }
            }
            MessageBox.Show(imageFilePath+"에 저장되었습니다.","information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bitmap.Save(@"resultpic\image1.bmp");
            this.Close();

        }
    }
}
