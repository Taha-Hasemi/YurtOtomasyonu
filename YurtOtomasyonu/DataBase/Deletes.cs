using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOtomasyonu.DataBase
{
    class Deletes
    {
        SqlConnection baglanti = new DataBase.GetConnectionString().BaglantiAdresi();
        public void Bolum_Sil(string bolum_ID)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Bolumler Where BolumID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", bolum_ID);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bölüm Başariyla Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Yonetici_Sil(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Yoneticiler where YoneticiID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1",id);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yönetici Başariyla Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Personel_Sil(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Personel where PersonelID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel Başariyla Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Ogrenci_Sil(int id)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Ogrenci where OgrID=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Başariyla Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
