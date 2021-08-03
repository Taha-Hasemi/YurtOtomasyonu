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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet8.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personel);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPersonelAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPersonelGorev.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void pcbEkle_Click(object sender, EventArgs e)
        {
            new DataBase.Inserts().Personel_Ekle(txtPersonelAd.Text, txtPersonelGorev.Text);
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personel);
            txtPersonelAd.Clear();
            txtPersonelGorev.Clear();
            txtPersonelID.Clear();
        }

        private void pcbSil_Click(object sender, EventArgs e)
        {
            new DataBase.Deletes().Personel_Sil(int.Parse(txtPersonelID.Text));
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personel);
        }

        private void pcbDuzenle_Click(object sender, EventArgs e)
        {
            new DataBase.Updates().Personel_Guncelle(int.Parse(txtPersonelID.Text), txtPersonelAd.Text, txtPersonelGorev.Text);
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personel);
        }
    }
}
