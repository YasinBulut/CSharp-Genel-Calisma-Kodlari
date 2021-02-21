using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 6;
            while (j <= 5)
            {
                listBox1.Items.Add("Eruzurum");
                j++;
            }

            int i = 6; // işlem yanlış olsa bile do while da en az bir kere ekrana yazdırır
            do
            {
                listBox2.Items.Add("Eruzurum");
                i++;
            } while (i<=5);

          
        }
    }
}
