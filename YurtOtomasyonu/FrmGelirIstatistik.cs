using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOtomasyonu
{
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new DataBase.GetConnectionString().BaglantiAdresi();
        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            lblKasadakiPara.Text = new DataBase.Selects().Kasadaki_Para(DateTime.Now.Year + "-" + DateTime.Now.Month) + " TL";

            //cmbTarih icerik getirme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select distinct(OdemeAy) From Kasa", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbTarih.Items.Add(oku[0].ToString());
            }
            baglanti.Close();

            //Chart Araci Veritabani Graphic Çekme
            chart1.Series["Aylik"].Points.Clear();
            try
            {
                SqlDataReader oku2 = new DataBase.Selects().Chart_Veri_Cekme(DateTime.Now.Year.ToString());
                while (oku2.Read())
                {
                    chart1.Series["Aylik"].Points.AddXY(oku2[0], oku2[1]);
                }
                baglanti.Close();
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKasadakiPara.Text = new DataBase.Selects().Kasadaki_Para(cmbTarih.Text) + " TL";
        }

        private void cmbYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chart Araci Veritabani Graphic Çekme
            chart1.Series["Aylik"].Points.Clear();
            try
            {
                SqlDataReader oku2 = new DataBase.Selects().Chart_Veri_Cekme(cmbYil.Text);
                while (oku2.Read())
                {
                    chart1.Series["Aylik"].Points.AddXY(oku2[0], oku2[1]);
                }
                baglanti.Close();
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
