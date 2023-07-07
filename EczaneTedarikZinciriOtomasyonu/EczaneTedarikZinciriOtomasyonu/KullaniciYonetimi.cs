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
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        EczaneTedarik genelSinif = new EczaneTedarik();
        
        public void butonFalse()
        {
            button1.Enabled = false;
            tcknTB.Enabled = false;
            kulAdiTB.Enabled = false;
            sifreTB.Enabled = false;
        }
        void TabloDoldur()
        {
            genelSinif.baglanti();
            OleDbDataAdapter da = new OleDbDataAdapter("select TCKN,KullaniciAdi,Sifre from KullaniciHesaplari",genelSinif.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "KullaniciHesaplari");
            dataGridView1.DataSource = ds.Tables["KullaniciHesaplari"];
        }
        private void ekleRB_CheckedChanged(object sender, EventArgs e)
        {
            butonFalse();
            button1.Enabled = true;
            button1.Text = "Kullanıcı Ekle";
            tcknTB.Enabled = true;
            kulAdiTB.Enabled = true;
            sifreTB.Enabled = true;
        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            butonFalse();
            TabloDoldur();
        }

        private void silRB_CheckedChanged(object sender, EventArgs e)
        {
            butonFalse();
            button1.Enabled = true;
            button1.Text = "Kullanıcı Sil";
            tcknTB.Enabled = true;
        }

        private void guncelleRB_CheckedChanged(object sender, EventArgs e)
        {
            butonFalse();
            button1.Enabled = true;
            button1.Text = "Kullanıcı Güncelle";
            tcknTB.Enabled = true;
            kulAdiTB.Enabled = true;
            sifreTB.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ekleRB.Checked)
            {
                if (String.IsNullOrEmpty(tcknTB.Text))
                {
                    MessageBox.Show("TCKN bilgisi boş olamaz.");
                }
                else if (String.IsNullOrEmpty(kulAdiTB.Text))
                {
                    MessageBox.Show("Kullanıcı Adı bilgisi boş olamaz.");
                }
                else if (String.IsNullOrEmpty(sifreTB.Text))
                {
                    MessageBox.Show("Şifre bilgisi boş olamaz.");
                }
                else
                {
                    genelSinif.baglanti();
                    OleDbCommand cmd2 = new OleDbCommand("select TCKN from KullaniciHesaplari where TCKN = '" + tcknTB.Text + "'",genelSinif.conn);
                    OleDbDataReader dr = cmd2.ExecuteReader();
                    OleDbCommand cmd3 = new OleDbCommand("select KullaniciAdi from KullaniciHesaplari where KullaniciAdi = '" + kulAdiTB.Text + "'", genelSinif.conn);
                    OleDbDataReader dr2 = cmd3.ExecuteReader();

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO KullaniciHesaplari(TCKN,KullaniciAdi,Sifre) VALUES (@tckn,@kullaniciAdi,@sifre)", genelSinif.conn);
                    cmd.Parameters.AddWithValue("@tckn", tcknTB.Text);
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kulAdiTB.Text);
                    cmd.Parameters.AddWithValue("@sifre", sifreTB.Text);
                    if (dr.Read())
                    {
                        MessageBox.Show("'"+tcknTB.Text+"' TCKN numarası ile kayıtlı bir hesap mevcut.");
                    }
                    else if (dr2.Read())
                    {
                        MessageBox.Show("'" + kulAdiTB.Text + "' kullanıcı adı ile bir hesap mevcut.");
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı Eklendi.");
                        TabloDoldur();
                    }
                    
                    
                }
            }
            else if (silRB.Checked)
            {
                genelSinif.baglanti();
                OleDbCommand cmd = new OleDbCommand("delete from KullaniciHesaplari where TCKN = @tckn;",genelSinif.conn);
                cmd.Parameters.AddWithValue("@tckn", tcknTB.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Silindi.");
                TabloDoldur();
            }
            else if (guncelleRB.Checked)
            {
                genelSinif.baglanti();
                OleDbCommand cmd2 = new OleDbCommand("select TCKN from KullaniciHesaplari where TCKN = '" + tcknTB.Text + "'", genelSinif.conn);
                OleDbDataReader dr = cmd2.ExecuteReader();
                if(dr.Read())
                {
                    if (String.IsNullOrEmpty(tcknTB.Text))
                    {
                        MessageBox.Show("TCKN bilgisi boş olamaz.");
                    }
                    else if (String.IsNullOrEmpty(kulAdiTB.Text))
                    {
                        MessageBox.Show("Kullanıcı Adı bilgisi boş olamaz.");
                    }
                    else if (String.IsNullOrEmpty(sifreTB.Text))
                    {
                        MessageBox.Show("Şifre bilgisi boş olamaz.");
                    }
                    else
                    {
                        OleDbCommand cmd = new OleDbCommand("UPDATE KullaniciHesaplari SET TCKN = '" + tcknTB.Text + "', KullaniciAdi = '" + kulAdiTB.Text + "', Sifre = '" + sifreTB.Text + "' where TCKN = '" + tcknTB.Text + "'", genelSinif.conn);
                        //cmd.Parameters.AddWithValue("@tckn", tcknTB.Text);
                        //cmd.Parameters.AddWithValue("@kulAdi", kulAdiTB.Text);
                        //cmd.Parameters.AddWithValue("@sifre", sifreTB.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı Güncellendi.");
                    }
                }
                
                else
                {
                    MessageBox.Show("'" + tcknTB.Text + "' TCKN bilgili hesap mevcut değildir.");
                }
                
                TabloDoldur();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            this.Hide();
            yoneticiPaneli.Show();
        }

        private void KullaniciYonetimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
