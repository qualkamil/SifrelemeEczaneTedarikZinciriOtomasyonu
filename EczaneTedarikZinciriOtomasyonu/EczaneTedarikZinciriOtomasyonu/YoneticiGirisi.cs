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
    public partial class YoneticiGirisi : Form
    {
        public YoneticiGirisi()
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

        private void YoneticiGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            genelSinif.Kapatma();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneDatabase.accdb;");
        private void button1_Click(object sender, EventArgs e)
        {
            genelSinif.baglanti();
            if(kulAdi.Text == "" || sifre.Text =="")
            {
                MessageBox.Show("Kullanici adı veya şifre boş olamaz.");
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand("select * from YoneticiHesaplari where KullaniciAdi = @kullaniciAdi and Sifre = @ssifre;", genelSinif.conn);
                cmd.Parameters.AddWithValue("@kullaniciAdi", kulAdi.Text);
                cmd.Parameters.AddWithValue("@ssifre", sifre.Text);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read()){
                    YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
                    this.Hide();
                    yoneticiPaneli.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız.");
                }

            }
        }
    }
}
