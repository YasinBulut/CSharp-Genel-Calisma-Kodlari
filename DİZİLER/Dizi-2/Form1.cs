using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Ankara", "Eskişehir", "Bursa", "Antalya", "Adana", "Erzurum" };
            for (int i = 0; i < sehirler.Length; i++)
            {
                listBox1.Items.Add((i+1)+" - "+sehirler[i]);
            }

            int[] sayilar = { 4, 2, 3, 1, 5, 6, 7, 9 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%2==0)
                {
                    listBox2.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
