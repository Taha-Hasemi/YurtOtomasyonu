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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtKalanBorc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            int odenen_Borc, kalan_Borc, yeni_Borc;
            odenen_Borc = Convert.ToInt32(txtOdenenBorc.Text);
            kalan_Borc = Convert.ToInt32(txtKalanBorc.Text);
            if (odenen_Borc <= kalan_Borc)
            {
                yeni_Borc = kalan_Borc - odenen_Borc;
                bool sonuc = new DataBase.Updates().Odemeleri_Guncelle(txtID.Text, yeni_Borc.ToString());
                if (sonuc)
                {
                    new DataBase.Inserts().Odemeleri_Kasaya_Kaydet(txtID.Text, DateTime.Now.Year + "-" + DateTime.Now.Month, txtOdenenBorc.Text);
                    txtKalanBorc.Text = yeni_Borc.ToString();
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz Miktar Kalan Borcdan Çok Büyük", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);
        }
    }
}
