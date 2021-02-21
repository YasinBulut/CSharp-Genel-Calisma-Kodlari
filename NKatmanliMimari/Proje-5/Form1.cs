using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using LogicLayer;

namespace Proje_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            ent.Gorev = txtgorev.Text;
            LogicPersonel.LLPersonelEkle(ent);
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtid.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtid.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            LogicPersonel.LLPersonelGuncelle(ent);

            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtgorev.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
           
        }
    }
}
