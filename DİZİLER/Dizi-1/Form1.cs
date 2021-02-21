using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Mehmet", "Demet", "Aslı", "Hakan", "Ayşe", "Ahmet" };
            //label1.Text = kisiler[4];

            int[] sayilar = { 4, 7, 5, 6, 9, 8, 2, 3 };
            label1.Text = sayilar[5].ToString();
        }
    }
}
