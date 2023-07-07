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
    public partial class KullaniciTedarikKontrol : Form
    {
        public KullaniciTedarikKontrol()
        {
            InitializeComponent();
        }
        EczaneTedarik genelSinif = new EczaneTedarik();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                genelSinif.baglanti();
                OleDbDataAdapter da = new OleDbDataAdapter("select TakipNo,UrunAdi,UrunNerede,UrunAdet,SKT,Aciklama from Tedarik where TakipNo = '" + takipNoAra.Text + "'", genelSinif.conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Tedarik");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata + "Hata ile karşılaşıldı.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                genelSinif.baglanti();
                OleDbDataAdapter da = new OleDbDataAdapter("select TakipNo,UrunAdi,UrunNerede,UrunAdet,SKT,Aciklama from Tedarik where UrunAdi = '" + urunAdiAra.Text + "'", genelSinif.conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Tedarik");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata + "Hata ile karşılaşıldı.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                genelSinif.baglanti();
                OleDbDataAdapter da = new OleDbDataAdapter("select TakipNo,UrunAdi,UrunNerede,UrunAdet,SKT,Aciklama from Tedarik", genelSinif.conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Tedarik");
                dataGridView1.DataSource = ds.Tables["Tedarik"];
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata + "Hata ile karşılaşıldı.");
            }
        }

        private void KullaniciTedarikKontrol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciPaneli kullaniciPaneli = new KullaniciPaneli();
            this.Hide();
            kullaniciPaneli.Show();
        }
    }
}
