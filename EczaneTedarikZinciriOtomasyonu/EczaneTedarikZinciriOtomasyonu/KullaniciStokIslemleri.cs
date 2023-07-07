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
    public partial class KullaniciStokIslemleri : Form
    {
        public KullaniciStokIslemleri()
        {
            InitializeComponent();
        }
        EczaneTedarik genelSinif = new EczaneTedarik();
        public void ButonFalse()
        {
            button1.Enabled = false;
            barkodTB.Enabled = false;
            urunAdiTB.Enabled = false;
            urunAdetTB.Enabled = false;
            fiyatTB.Enabled = false;
            sktTB.Enabled = false;
        }
        void TabloDoldur()
        {
            genelSinif.baglanti();
            OleDbDataAdapter da = new OleDbDataAdapter("select BarkodNo,UrunAdi,UrunAdet,UrunFiyat,SKT from Stok", genelSinif.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Stok");
            dataGridView1.DataSource = ds.Tables["Stok"];
        }
        private void KullaniciStokIslemleri_Load(object sender, EventArgs e)
        {
            ButonFalse();
            TabloDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ekleRB.Checked)
                {
                    if (String.IsNullOrEmpty(barkodTB.Text))
                    {
                        MessageBox.Show("Barkod No bilgisi boş olamaz.");
                        MessageBox.Show(sktTB.Text);
                    }
                    else if (String.IsNullOrEmpty(urunAdiTB.Text))
                    {
                        MessageBox.Show("Ürün Adı bilgisi boş olamaz.");
                    }
                    else if (String.IsNullOrEmpty(urunAdetTB.Text))
                    {
                        MessageBox.Show("Ürün Adet bilgisi boş olamaz.");
                    }
                    else if (String.IsNullOrEmpty(fiyatTB.Text))
                    {
                        MessageBox.Show("Fiyat bilgisi boş olamaz");
                    }
                    else if (String.IsNullOrEmpty(sktTB.Text))
                    {
                        MessageBox.Show("Son Kullanma Tarihi bilgisi boş olamaz");
                    }
                    else
                    {
                        OleDbCommand cmd2 = new OleDbCommand("select BarkodNo from Stok where BarkodNo = '" + barkodTB.Text + "'", genelSinif.conn);
                        OleDbDataReader dr = cmd2.ExecuteReader();
                        OleDbCommand cmd3 = new OleDbCommand("select UrunAdi from Stok where UrunAdi = '" + urunAdiTB.Text + "'", genelSinif.conn);
                        OleDbDataReader dr2 = cmd3.ExecuteReader();
                        OleDbCommand cmd = new OleDbCommand("INSERT INTO Stok(BarkodNo,UrunAdi,UrunAdet,UrunFiyat,SKT) VALUES (@barkodNo,@urunAdi,@urunAdet,@urunFiyat,@skt)", genelSinif.conn);
                        cmd.Parameters.AddWithValue("@barkodNo", barkodTB.Text);
                        cmd.Parameters.AddWithValue("@urunAdi", urunAdiTB.Text);
                        cmd.Parameters.AddWithValue("@urunAdet", urunAdetTB.Text);
                        cmd.Parameters.AddWithValue("@urunFiyat", fiyatTB.Text);
                        cmd.Parameters.AddWithValue("@skt", sktTB.Text.ToString());
                        if (dr.Read())
                        {
                            MessageBox.Show("'" + barkodTB.Text + "' Barkod numarası ile kayıtlı bir ürün mevcut.");
                        }
                        else if (dr2.Read())
                        {
                            MessageBox.Show("'" + urunAdiTB.Text + "' ürün adı ile bir ürün mevcut.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Ürün Eklendi.");
                            TabloDoldur();
                        }

                    }
                }
                else if (guncelleRB.Checked)
                {

                    genelSinif.baglanti();
                    OleDbCommand cmd2 = new OleDbCommand("select BarkodNo from Stok where BarkodNo=@barkodNo", genelSinif.conn);
                    cmd2.Parameters.AddWithValue("@barkodNo", barkodTB.Text);
                    OleDbDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        if (String.IsNullOrEmpty(barkodTB.Text))
                        {
                            MessageBox.Show("Barkod No bilgisi boş olamaz");
                        }
                        else if (String.IsNullOrEmpty(urunAdiTB.Text))
                        {
                            MessageBox.Show("Ürün Adı bilgisi boş olamaz");
                        }
                        else if (String.IsNullOrEmpty(urunAdetTB.Text))
                        {
                            MessageBox.Show("Ürün Adet bilgisi boş olamaz");
                        }
                        else if (String.IsNullOrEmpty(fiyatTB.Text))
                        {
                            MessageBox.Show("Ürün Fiyat bilgisi boş olamaz");
                        }
                        else if (String.IsNullOrEmpty(sktTB.Text))
                        {
                            MessageBox.Show("SKT bilgisi boş olamaz");
                        }
                        else
                        {
                            OleDbCommand cmd = new OleDbCommand("UPDATE Stok SET BarkodNo=@barkodNo,UrunAdi=@urunAdi,UrunAdet=@urunAdet,UrunFiyat=@urunFiyat where BarkodNo=@barkodNo", genelSinif.conn);
                            cmd.Parameters.AddWithValue("@barkodNo", barkodTB.Text);
                            cmd.Parameters.AddWithValue("@urunAdi", urunAdiTB.Text);
                            cmd.Parameters.AddWithValue("@urunAdet", urunAdetTB.Text);
                            cmd.Parameters.AddWithValue("@urunFiyat", fiyatTB.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Ürün Güncellendi");
                            TabloDoldur();
                        }
                    }
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata + "Hata ile karşılaşıldı.");
            }
        }

        private void guncelleRB_CheckedChanged(object sender, EventArgs e)
        {
            ButonFalse();
            ButonFalse();
            button1.Text = "Ürün Güncelle";
            button1.Enabled = true;
            barkodTB.Enabled = true;
            urunAdiTB.Enabled = true;
            urunAdetTB.Enabled = true;
            fiyatTB.Enabled = true;
        }

        private void ekleRB_CheckedChanged(object sender, EventArgs e)
        {
            ButonFalse();
            button1.Text = "Ürün Ekle";
            button1.Enabled = true;
            barkodTB.Enabled = true;
            urunAdiTB.Enabled = true;
            urunAdetTB.Enabled = true;
            fiyatTB.Enabled = true;
            sktTB.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                genelSinif.baglanti();
                OleDbDataAdapter da = new OleDbDataAdapter("select BarkodNo,UrunAdi,UrunAdet,UrunFiyat,SKT from Stok where BarkodNo like '%" + barkodAra.Text + "%'", genelSinif.conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Stok");
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
                OleDbDataAdapter da = new OleDbDataAdapter("select BarkodNo,UrunAdi,UrunAdet,UrunFiyat,SKT from Stok where UrunAdi like '%" + stokAra.Text + "%'", genelSinif.conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "UrunAdi");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata + "Hata ile karşılaşıldı.");
            }
        }

        private void KullaniciStokIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciPaneli kullaniciPaneli = new KullaniciPaneli();
            this.Hide();
            kullaniciPaneli.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
