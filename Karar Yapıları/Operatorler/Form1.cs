using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="ali")
            {
                label1.Text = "Doğru";
            }
            else
            {
                label1.Text = "Yanlış"; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);
            if (sayi % 2 ==0 && sayi>=10)
            {
                label2.Text = "10 dan buyuk ve çift";
            }
            else
            {
                label2.Text = "10 dan buyuk değil veya çift değil";
            }
        }
    }
}
