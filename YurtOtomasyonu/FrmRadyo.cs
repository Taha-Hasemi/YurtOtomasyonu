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
    public partial class FrmRadyo : Form
    {
        public FrmRadyo()
        {
            InitializeComponent();
        }
        public string url, kanal_Ad;
        private void FrmRadyo_Load(object sender, EventArgs e)
        {
            label1.Text = kanal_Ad;
            axWindowsMediaPlayer1.URL = url;
        }
    }
}
