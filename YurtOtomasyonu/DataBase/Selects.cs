using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtOtomasyonu.DataBase
{
    class Selects
    {
        SqlConnection baglanti = new DataBase.GetConnectionString().BaglantiAdresi();

        public OgrenciBilgileri Ogrenci_Bilgileri(int id)
        {
            try
            {
                OgrenciBilgileri OgrBlg = new OgrenciBilgileri();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Ogrenci Where OgrID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    OgrBlg.id = Convert.ToInt32(oku[0]);
                    OgrBlg.ogrAd = oku[1].ToString();
                    OgrBlg.ogrSoyad = oku[2].ToString();
                    OgrBlg.ogrTC = oku[3].ToString();
                    OgrBlg.ogrTelefon = oku[4].ToString();
                    OgrBlg.ogrDogum = Convert.ToDateTime(oku[5]);
                    OgrBlg.ogrBolum = oku[6].ToString();
                    OgrBlg.ogrMail = oku[7].ToString();
                    OgrBlg.ogrOdaNo = oku[8].ToString();
                    OgrBlg.ogrVeliAdSoyad = oku[9].ToString();
                    OgrBlg.ogrVeliTelefon = oku[10].ToString();
                    OgrBlg.ogrVeliAdres = oku[11].ToString();
                }
                baglanti.Close();
                return OgrBlg;
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public GiderBilgileri Gider_Bilgileri(int id)
        {
            try
            {
                GiderBilgileri gdrBlg = new GiderBilgileri();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Giderler where OdemeID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    gdrBlg.ID = Convert.ToInt32(oku[0].ToString());
                    gdrBlg.elektirik = oku[1].ToString();
                    gdrBlg.su = oku[2].ToString();
                    gdrBlg.dogalGaz = oku[3].ToString();
                    gdrBlg.internet = oku[4].ToString();
                    gdrBlg.gida = oku[5].ToString();
                    gdrBlg.personel = oku[6].ToString();
                    gdrBlg.diger = oku[7].ToString();
                }
                baglanti.Close();
                return gdrBlg;
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public string Kasadaki_Para(string tarih)
        {
            try
            {
                string id = "";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select sum(OdemeMiktar) from Kasa where OdemeAy like @p1 ", baglanti);
                komut.Parameters.AddWithValue("@p1", tarih);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    id = oku[0].ToString();
                }
                baglanti.Close();
                return id;
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
        public bool Admin_Giris(string kullanici_Ad, string kullanici_Sifre)
        {
            try
            {
                bool durum = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Yoneticiler where YoneticiAd=@p1 and YoneticiSifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", kullanici_Ad.ToLower());
                komut.Parameters.AddWithValue("@p2", kullanici_Sifre);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("KullanıcıAdı Veya Şifre Yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
                return durum;
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public SqlDataReader Chart_Veri_Cekme(string yil)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select OdemeAy,sum(OdemeMiktar) from Kasa where OdemeAy like'%" + yil + "%' Group by OdemeAy", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                return oku;
                baglanti.Close();
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
