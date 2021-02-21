using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rastgele;
            Point konum = new Point();
            Random rn = new Random();
            rastgele = rn.Next(100, 300);
            konum.X = rastgele;
            konum.Y = rastgele;
            pictureBox1.Location = konum;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 10;
        }
    }
}
