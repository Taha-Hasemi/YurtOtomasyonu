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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet1.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Ogrenci);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }
        private void radyo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadyo frmRadyo = new FrmRadyo();
            frmRadyo.kanal_Ad = "ITU";
            frmRadyo.url = "http://radyo.itu.edu.tr/ITU_Radio_Classic.asx";
            frmRadyo.Show();
        }

        private void radyo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadyo frmRadyo = new FrmRadyo();
            frmRadyo.kanal_Ad = "Taksim";
            frmRadyo.url = "http://cast1.taksim.fm:8000";
            frmRadyo.Show();
        }

        private void radyo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadyo frmRadyo = new FrmRadyo();
            frmRadyo.kanal_Ad = "BroadWave";
            frmRadyo.url = "http://88.255.140.50:88/broadwave.m3u?src=1&rate=1";
            frmRadyo.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOgrKayit().Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOgrListe().Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBolumler().Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBolumler().Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOdemeler().Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGiderler().Show();
        }

        private void giderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGiderListesi().Show();
        }

        private void gelırİstatislikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGelirIstatistik().Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmYoneticiDuzenle().Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPersonel().Show();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNotEkle().Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Kızıl Aslan tarafından 3 Ağustos 2021 de tamamlanmıştır.", "Öğrenci Yurt Otomasyonu",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
