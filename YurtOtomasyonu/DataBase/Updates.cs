using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOtomasyonu.DataBase
{
    class Updates
    {
        SqlConnection baglanti = new DataBase.GetConnectionString().BaglantiAdresi();

        public void Ogrenci_Guncelle(OgrenciBilgileri ogrenciBilgileri)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Ogrenci set OgrTelefon=@p2,OgrBolum=@p3,OgrMail=@p4,OgrOdaNo=@p5,OgrVeliTelefon=@p6,OgrVeliAdres=@p7 where OgrID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", ogrenciBilgileri.id);
                komut.Parameters.AddWithValue("@p2", ogrenciBilgileri.ogrTelefon);
                komut.Parameters.AddWithValue("@p3", ogrenciBilgileri.ogrBolum);
                komut.Parameters.AddWithValue("@p4", ogrenciBilgileri.ogrMail);
                komut.Parameters.AddWithValue("@p5", ogrenciBilgileri.ogrOdaNo);
                komut.Parameters.AddWithValue("@p6", ogrenciBilgileri.ogrVeliTelefon);
                komut.Parameters.AddWithValue("@p7", ogrenciBilgileri.ogrVeliAdres);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Başariyla Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Bolum_Guncelle(string bolum_ID, string bolum_Ad)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Bolumler set BolumAd=@p2 where BolumID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", bolum_ID);
                komut.Parameters.AddWithValue("@p2", bolum_Ad);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bölüm Başariyla Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool Odemeleri_Guncelle(string id, string kalan_Borc)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Borclar set OgrKalanBorc=@p2 where OgrID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", kalan_Borc);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Borc Ödendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void Giderleri_Guncelle(GiderBilgileri giderBilgileri)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Giderler set Elektirik=@p2,Su=@p3,DogalGaz=@p4,Internet=@p5,Gida=@p6,Personel=@p7,Diger=@p8 where OdemeID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", giderBilgileri.ID);
                komut.Parameters.AddWithValue("@p2", giderBilgileri.elektirik);
                komut.Parameters.AddWithValue("@p3", giderBilgileri.su);
                komut.Parameters.AddWithValue("@p4", giderBilgileri.dogalGaz);
                komut.Parameters.AddWithValue("@p5", giderBilgileri.internet);
                komut.Parameters.AddWithValue("@p6", giderBilgileri.gida);
                komut.Parameters.AddWithValue("@p7", giderBilgileri.personel);
                komut.Parameters.AddWithValue("@p8", giderBilgileri.diger);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Gider Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Yonetici_Guncelle(int id, string yonetici_Ad, string yonetici_Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Yoneticiler set YoneticiAd=@p2,YoneticiSifre=@p3 where YoneticiID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", yonetici_Ad);
                komut.Parameters.AddWithValue("@p3", yonetici_Sifre);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yonetici Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Personel_Guncelle(int id, string personel_Ad, string personel_Gorev)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Personel set PersonelAdSoyad=@p2,PersonelDepartman=@p3 where PersonelID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", personel_Ad);
                komut.Parameters.AddWithValue("@p3", personel_Gorev);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
