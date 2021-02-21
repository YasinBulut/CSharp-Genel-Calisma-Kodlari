using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ardışıksayılarıntoplamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int çifttoplam=0;
            for (int i = 0; i <= 5; i++)
            {
                toplam = toplam + i;
            }
            listBox1.Items.Add("Toplam= " + toplam);
            for (int i = 0; i <= 5; i+=2)
            {
                çifttoplam = çifttoplam + i;
            }
            listBox1.Items.Add("Çift Sayıların toplamı= "+çifttoplam);
        }
    }
}
