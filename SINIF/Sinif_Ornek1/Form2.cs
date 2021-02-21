using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();
            rb2.renk = "Yeşil";
            rb2.hiz = 140;
            rb2.motor = 1220.36;
            rb2.fiyat = 35000;
            rb2.durum = 'İ';
            rb2.muayene = 2017;
            rb2.plaka = "34 Aİ 1881";
            rb2.sahip = "Ahmet Çakar";

            label1.Text = rb2.renk;
            label2.Text = rb2.hiz.ToString();
            label3.Text = rb2.motor.ToString();
            label4.Text = rb2.fiyat.ToString();
            label5.Text = rb2.durum.ToString();
            label8.Text = rb2.muayene.ToString();
            label9.Text = rb2.plaka;
            label10.Text = rb2.sahip;
            pictureBox1.BackColor = Color.Red;
        }
    }
}
