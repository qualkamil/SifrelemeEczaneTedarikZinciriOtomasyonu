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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }
        EczaneTedarik genelSinif = new EczaneTedarik();
        private void YoneticiPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            genelSinif.Kapatma();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Hide();
            kullaniciYonetimi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StokIslemleri stokIslemleri = new StokIslemleri();
            this.Hide();
            stokIslemleri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YoneticiTedarikKontrol yoneticiTedarikKontrol = new YoneticiTedarikKontrol();
            this.Hide();
            yoneticiTedarikKontrol.Show();
        }
    }
}
