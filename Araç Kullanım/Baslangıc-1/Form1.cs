using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baslangıc_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl2.Text = "Muhammet";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Yasin";
            label5.Text = "Bulut";
            label6.Text = "Mühendis";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazılım Mühendisliği"; 
            label7.Text = textBox1.Text;
        }
    }
}
