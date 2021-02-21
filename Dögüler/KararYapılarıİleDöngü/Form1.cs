using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapılarıİleDöngü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);           
            int sayi2 = Convert.ToInt32(textBox2.Text);
            for (int i = 1; i <= 100; i++)
            {
                if (i % sayi1 == 0  && i % sayi2 == 0) //sayi1 ve sayi2 bolunen sayıları yazdırır
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
