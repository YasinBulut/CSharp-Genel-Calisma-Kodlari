using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void renklendir()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Blue;
            textBox3.BackColor = Color.Yellow;
            textBox4.BackColor = Color.Lime;
        }
        private void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
    }
}
