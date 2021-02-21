using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnteger_ornek
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
            sayi = Convert.ToInt16(textBox1.Text);
            label2.Text = "Sayi: "+sayi.ToString();
            label3.Text = "Karesi: " + (sayi * sayi);
            label4.Text = "Küp: " + (sayi * sayi * sayi);
        }
    }
}
