using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneTedarikZinciriOtomasyonu
{
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
        {
            InitializeComponent();
        }

        private void KullaniciPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciTedarikKontrol kullaniciTedarikKontrol = new KullaniciTedarikKontrol();
            this.Hide();
            kullaniciTedarikKontrol.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciStokIslemleri kullaniciStokIslemleri = new KullaniciStokIslemleri();
            this.Hide();
            kullaniciStokIslemleri.Show();
        }
    }
}
