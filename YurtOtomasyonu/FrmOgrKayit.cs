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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new DataBase.GetConnectionString().BaglantiAdresi();

        private void BolumlerComboBox()
        {
            cmbOgrBolum.Items.Clear();
            cmbOgrBolum.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select BolumAd from Bolumler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbOgrBolum.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }
        private void OdalarComboBox()
        {
            cmbOdaNo.Items.Clear();
            cmbOdaNo.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select OdaNo from Odalar where OdaKapasite != OdaAktif", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbOdaNo.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            BolumlerComboBox();
            OdalarComboBox();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OgrenciBilgileri ogrenciBilgileri = new OgrenciBilgileri()
            {
                ogrAd = txtOgrAd.Text,
                ogrSoyad = txtOgrSoyad.Text,
                ogrTC = mskTC.Text,
                ogrTelefon = mskOgrTelefon.Text,
                ogrDogum = Convert.ToDateTime(mskOgrDogumTarih.Text),
                ogrBolum = cmbOgrBolum.Text,
                ogrMail = txtOgrMail.Text,
                ogrOdaNo = cmbOdaNo.Text,
                ogrVeliAdSoyad = txtVeliAdSoyad.Text,
                ogrVeliTelefon = mskVeliTelefon.Text,
                ogrVeliAdres = rchTxtVeliAdres.Text
            };
            new DataBase.Inserts().Ogrenci_Ekle(ogrenciBilgileri);
            BolumlerComboBox();
            OdalarComboBox();
            txtOgrAd.Clear();
            txtOgrSoyad.Clear();
            txtOgrMail.Clear();
            txtVeliAdSoyad.Clear();
            rchTxtVeliAdres.Clear();
            mskOgrDogumTarih.Clear();
            mskOgrTelefon.Clear();
            mskTC.Clear();
            mskVeliTelefon.Clear();
        }
    }
}
