using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ortalama;
            s1 = 60;
            s2 = 70;
            s3 = 79;
            ortalama = (s3 + s2 + s1) / 3;
            label1.Text = ortalama.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            label2.Text = sayi.ToString();  
        }
    }
}
