using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_BilgiYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;
        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            label2.Text = btna.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
            }
            else
            {
                yanlıs++;
                lbly.Text = yanlıs.ToString();
            }
        }
        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            label2.Text = btnb.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
            }
            else
            {
                yanlıs++;
                lbly.Text = yanlıs.ToString();
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            label2.Text = btnc.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
            }
            else
            {
                yanlıs++;
                lbly.Text = yanlıs.ToString();
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            label2.Text = btnd.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
            }
            else
            {
                yanlıs++;
                lbly.Text = yanlıs.ToString();
            }
        }   

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonraki.Enabled = false;

            soruno++;
            lblsoru.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btna.Text = "1910";
                btnb.Text = "1920";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label1.Text = "1923";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangisi Şehir ege bölgemizde bulunmaz?";
                btna.Text = "İzmir";
                btnb.Text = "Balıkesir";
                btnc.Text = "Aydın";
                btnd.Text = "Manisa";
                label1.Text = "Balıkesir";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Son kuşlar hangi yazarımıza aittir?";
                btna.Text = "Sait Faik";
                btnb.Text = "Cemal Süreyya";
                btnc.Text = "Necip Fazılkısakürek";
                btnd.Text = "Attilla İlhan";
                label1.Text = "Sait Faik";
                btnsonraki.Text = "Sonuçlar";
            }
            if (soruno==4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("Doğru: "+dogru+" "+"Yanlış: "+yanlıs);
            }
        }
    }
}
