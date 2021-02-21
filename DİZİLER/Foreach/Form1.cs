using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Mesut", "Pınar", "Berna" };
            foreach (var kisi in kisiler)
            {
                listBox1.Items.Add(kisi);
            }

            int toplam = 0;
            int[] sinavlar = { 70, 65, 85, 100, 90 };
            foreach (int sinav in sinavlar)
            {
                listBox2.Items.Add(sinav);
                toplam = toplam + sinav;
            }
            label1.Text = toplam.ToString();

            int ortalama = toplam / sinavlar.Length;
            label2.Text = ortalama.ToString();
        }
    }
}
