using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tarih,ad,soyad,meslek;
            tarih = "Merhaba Bugun 17 Kasım 2020";
            ad = "Yasin";
            soyad = "Bulut";
            meslek = "Mühendis";
            label1.Text = tarih;
            label2.Text = ad;
            label3.Text = soyad;
            label4.Text = meslek;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sehir;
            sehir = textBox1.Text;
            label5.Text = sehir;
        }
    }
}
