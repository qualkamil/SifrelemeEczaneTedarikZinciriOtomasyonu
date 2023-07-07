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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }
        EczaneTedarik genelSinif = new EczaneTedarik();
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void KullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            genelSinif.Kapatma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                genelSinif.baglanti();
                if (kulAdi.Text == "" || sifre.Text == "")
                {
                    MessageBox.Show("Kullanici adı veya şifre boş olamaz.");
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand("select * from KullaniciHesaplari where KullaniciAdi = @kullaniciAdi and Sifre = @ssifre;", genelSinif.conn);
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kulAdi.Text);
                    cmd.Parameters.AddWithValue("@ssifre", sifre.Text);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        KullaniciPaneli kullaniciPaneli = new KullaniciPaneli();
                        this.Hide();
                        kullaniciPaneli.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş yaptınız.");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata + "Hata ile karşılaşıldı.");
            }
        }
    }
}
