using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(tbxmısır.Text);
            bilet = Convert.ToInt16(tbxbilet.Text);
            su = Convert.ToInt16(tbxsu.Text);
            cay = Convert.ToInt16(tbxcay.Text);

            toplam = misir * 6 + cay * 3 + su * 2 + bilet * 15;
            lbltoplam.Text = toplam.ToString()+" TL ";


            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + " TL";
        }
    }
}
