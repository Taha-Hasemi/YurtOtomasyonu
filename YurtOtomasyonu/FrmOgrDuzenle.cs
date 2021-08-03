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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public int id;

        SqlConnection baglanti = new DataBase.GetConnectionString().BaglantiAdresi();
        private void BolumlerComboBox()
        {
            cmbOgrBolum.Items.Clear();
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select OdaNo from Odalar where OdaKapasite != OdaAktif", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbOdaNo.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            BolumlerComboBox();
            OdalarComboBox();


            OgrenciBilgileri ogrenciBilgileri = new DataBase.Selects().Ogrenci_Bilgileri(id);
            if (ogrenciBilgileri != null)
            {
                txtID.Text = ogrenciBilgileri.id.ToString();
                txtOgrAd.Text = ogrenciBilgileri.ogrAd;
                txtOgrSoyad.Text = ogrenciBilgileri.ogrSoyad;
                mskTC.Text = ogrenciBilgileri.ogrTC;
                mskOgrTelefon.Text = ogrenciBilgileri.ogrTelefon;
                mskOgrDogumTarih.Text = ogrenciBilgileri.ogrDogum.ToString();
                cmbOgrBolum.Text = ogrenciBilgileri.ogrBolum;
                txtOgrMail.Text = ogrenciBilgileri.ogrMail;
                cmbOdaNo.Text = ogrenciBilgileri.ogrOdaNo;
                txtVeliAdSoyad.Text = ogrenciBilgileri.ogrVeliAdSoyad;
                mskVeliTelefon.Text = ogrenciBilgileri.ogrVeliTelefon;
                rchTxtVeliAdres.Text = ogrenciBilgileri.ogrVeliAdres;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OgrenciBilgileri ogrenciBilgileri = new OgrenciBilgileri()
            {
                id = Convert.ToInt32(txtID.Text),
                ogrTelefon = mskOgrTelefon.Text,
                ogrBolum = cmbOgrBolum.Text,
                ogrMail = txtOgrMail.Text,
                ogrOdaNo = cmbOdaNo.Text,
                ogrVeliTelefon = mskVeliTelefon.Text,
                ogrVeliAdres = rchTxtVeliAdres.Text
            };
            new DataBase.Updates().Ogrenci_Guncelle(ogrenciBilgileri);


        }

        private void FrmOgrDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FrmOgrListe().Yenileme();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            new DataBase.Deletes().Ogrenci_Sil(int.Parse(txtID.Text));
        }
    }
}
