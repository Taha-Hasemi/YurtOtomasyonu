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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool durum = new DataBase.Selects().Admin_Giris(txtKullaniciAd.Text, txtKullaniciSifre.Text);
            if (durum)
            {
                new FrmAnaForm().Show();
                this.Hide();
            }
            else
            {
                txtKullaniciAd.Clear();
                txtKullaniciSifre.Clear();
            }
        }
    }
}
