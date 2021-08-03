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
    public partial class FrmGiderDuzenle : Form
    {
        public FrmGiderDuzenle()
        {
            InitializeComponent();
        }
        public int id;

        private void FrmGiderDuzenle_Load(object sender, EventArgs e)
        {
            GiderBilgileri giderBilgileri = new DataBase.Selects().Gider_Bilgileri(id);

            txtID.Text = giderBilgileri.ID.ToString();
            txtElektirik.Text = giderBilgileri.elektirik;
            txtSu.Text = giderBilgileri.su;
            txtDogalGaz.Text = giderBilgileri.dogalGaz;
            txtInternet.Text = giderBilgileri.internet;
            txtGida.Text = giderBilgileri.gida;
            txtPersonel.Text = giderBilgileri.personel;
            txtDiger.Text = giderBilgileri.diger;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GiderBilgileri giderBilgileri = new GiderBilgileri()
            {
                ID = Convert.ToInt32(txtID.Text),
                elektirik = txtElektirik.Text,
                su = txtSu.Text,
                dogalGaz = txtDogalGaz.Text,
                internet = txtInternet.Text,
                gida = txtGida.Text,
                personel = txtPersonel.Text,
                diger = txtDiger.Text
            };

            //veritabani
            new DataBase.Updates().Giderleri_Guncelle(giderBilgileri);
        }
    }
}
