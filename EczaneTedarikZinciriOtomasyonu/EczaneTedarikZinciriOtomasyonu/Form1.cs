using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EczaneTedarikZinciriOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EczaneTedarik genelSinif = new EczaneTedarik();
        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiGirisi yoneticiGirisi = new YoneticiGirisi();
            this.Hide();
            yoneticiGirisi.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            genelSinif.Kapatma();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciGirisi kullaniciGirisi = new KullaniciGirisi();
            this.Hide();
            kullaniciGirisi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
