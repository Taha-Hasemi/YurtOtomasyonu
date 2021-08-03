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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            
        }

        private void pcbEkle_Click(object sender, EventArgs e)
        {
            new DataBase.Inserts().Bolum_Ekle(txtBolumAd.Text);
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
        }

        private void pcbSil_Click(object sender, EventArgs e)
        {
            new DataBase.Deletes().Bolum_Sil(txtBolumID.Text);
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBolumID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBolumAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void pcbDuzenle_Click(object sender, EventArgs e)
        {
            new DataBase.Updates().Bolum_Guncelle(txtBolumID.Text, txtBolumAd.Text);
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
        }
    }
}
