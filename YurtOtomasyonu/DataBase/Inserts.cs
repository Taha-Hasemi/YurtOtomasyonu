using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtOtomasyonu.DataBase
{
    class Inserts
    {
        SqlConnection baglanti = new GetConnectionString().BaglantiAdresi();
        public void Ogrenci_Ekle(OgrenciBilgileri ogrenciBilgileri)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Ogrenci values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
                komut.Parameters.AddWithValue("@p1", ogrenciBilgileri.ogrAd);
                komut.Parameters.AddWithValue("@p2", ogrenciBilgileri.ogrSoyad);
                komut.Parameters.AddWithValue("@p3", ogrenciBilgileri.ogrTC);
                komut.Parameters.AddWithValue("@p4", ogrenciBilgileri.ogrTelefon);
                komut.Parameters.AddWithValue("@p5", ogrenciBilgileri.ogrDogum);
                komut.Parameters.AddWithValue("@p6", ogrenciBilgileri.ogrBolum);
                komut.Parameters.AddWithValue("@p7", ogrenciBilgileri.ogrMail);
                komut.Parameters.AddWithValue("@p8", ogrenciBilgileri.ogrOdaNo);
                komut.Parameters.AddWithValue("@p9", ogrenciBilgileri.ogrVeliAdSoyad);
                komut.Parameters.AddWithValue("@p10", ogrenciBilgileri.ogrVeliTelefon);
                komut.Parameters.AddWithValue("@p11", ogrenciBilgileri.ogrVeliAdres);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başariyla Kaydedildi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Bolum_Ekle(string bolum_Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into Bolumler (BolumAd) Values(@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", bolum_Ad);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bölüm Başariyla Kaydedildi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Giderleri_Ekle(GiderBilgileri giderBilgileri)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Giderler Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", giderBilgileri.elektirik);
                komut.Parameters.AddWithValue("@p2", giderBilgileri.su);
                komut.Parameters.AddWithValue("@p3", giderBilgileri.dogalGaz);
                komut.Parameters.AddWithValue("@p4", giderBilgileri.internet);
                komut.Parameters.AddWithValue("@p5", giderBilgileri.gida);
                komut.Parameters.AddWithValue("@p6", giderBilgileri.personel);
                komut.Parameters.AddWithValue("@p7", giderBilgileri.diger);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Giderler Başariyla Kaydedildi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Odemeleri_Kasaya_Kaydet(string ID, string ay, string odenen_Miktar)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Kasa Values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", ID);
                komut.Parameters.AddWithValue("@p2", ay);
                komut.Parameters.AddWithValue("@p3", odenen_Miktar);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Yonetici_Ekle(string yonetici_Ad,string yonetici_Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into Yoneticiler values (@p1,@p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", yonetici_Ad);
                komut.Parameters.AddWithValue("@p2", yonetici_Sifre);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yönetici Başariyla Kaydedildi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Personel_Ekle(string Personel_AdSoyad, string personel_Gorev)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into Personel values (@p1,@p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", Personel_AdSoyad);
                komut.Parameters.AddWithValue("@p2", personel_Gorev);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel Başariyla Kaydedildi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
