using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }

        private void FrmYoneticiDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet7.Yoneticiler' table. You can move, or remove it, as needed.
            this.yoneticilerTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Yoneticiler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKullaniciID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKullaniciAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtKullaniciSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void pcbEkle_Click(object sender, EventArgs e)
        {
            new DataBase.Inserts().Yonetici_Ekle(txtKullaniciAd.Text, txtKullaniciSifre.Text);
            this.yoneticilerTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Yoneticiler);
        }

        private void pcbSil_Click(object sender, EventArgs e)
        {
            new DataBase.Deletes().Yonetici_Sil(Convert.ToInt32(txtKullaniciID.Text));
            this.yoneticilerTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Yoneticiler);
        }

        private void pcbDuzenle_Click(object sender, EventArgs e)
        {
            new DataBase.Updates().Yonetici_Guncelle(int.Parse(txtKullaniciID.Text), txtKullaniciAd.Text, txtKullaniciSifre.Text);
            this.yoneticilerTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Yoneticiler);
        }
    }
}
