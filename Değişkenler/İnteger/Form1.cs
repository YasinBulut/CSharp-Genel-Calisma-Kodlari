using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnteger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = 25;
            label1.Text = Convert.ToString(sayi);
            int sayi1, sayi2,toplam;
            sayi1 = 5;
            sayi2 = 7;
            toplam = sayi1 + sayi2;
            label2.Text = "Toplama: "+toplam.ToString();
            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label3.Text = "Alan: " + alan+" Cevre: "+cevre;
        }
    }
}
