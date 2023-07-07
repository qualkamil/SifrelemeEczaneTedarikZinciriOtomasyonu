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
using System.Security.Cryptography;

namespace EczaneTedarikZinciriOtomasyonu
{
    public partial class YoneticiTedarikKontrol : Form
    {
        public YoneticiTedarikKontrol()
        {
            InitializeComponent();
        }
        EczaneTedarik genelSinif = new EczaneTedarik();

       

        public void TabloDoldur()
        {
            genelSinif.baglanti();
            OleDbDataAdapter da = new OleDbDataAdapter("select TakipNo,UrunAdi,UrunNerede,UrunAdet,SKT,Aciklama from Tedarik", genelSinif.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tedarik");
            dataGridView1.DataSource = ds.Tables["Tedarik"];
        }
        public void ButonFalse()
        {
            button1.Enabled = false;
            urunAdiTB.Enabled = false;
            urunAdetTB.Enabled = false;
            urunNeredeCB.Enabled = false;
            aciklamaRTB.Enabled = false;
            sktDTP.Enabled = false;
            sifrelenenTB.Enabled = false;
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            this.Hide();
            yoneticiPaneli.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void YoneticiTedarikKontrol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        static string key { get; set; } = "abcd";
        public static string Decrypt(string cipher)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(cipher);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static string Encrypt(string text)
        {
            byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleRB.Checked)
            {

                if (String.IsNullOrEmpty(urunAdiTB.Text))
                {
                    MessageBox.Show("Ürün Adı bilgisi boş olamaz.");
                }
                else if (String.IsNullOrEmpty(urunNeredeCB.Text))
                {
                    MessageBox.Show("Ürünün Nerede olduğu bilgisi boş olamaz");
                }
                else if (String.IsNullOrEmpty(urunAdetTB.Text))
                {
                    MessageBox.Show("Ürün Adet bilgisi boş olamaz.");
                }
                else if (String.IsNullOrEmpty(sktDTP.Text))
                {
                    MessageBox.Show("Son Kullanma Tarihi bilgisi boş olamaz");
                }
                else if (String.IsNullOrEmpty(aciklamaRTB.Text))
                {
                    MessageBox.Show("Açıklama bilgisi boş olamaz");
                }
                else
                {

                    string decryptText = Decrypt(sifrelenenTB.Text);
                    MessageBox.Show(decryptText);
                    string encryptText = Encrypt(decryptText);
                    MessageBox.Show(encryptText);
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Tedarik(UrunAdi,UrunNerede,TakipNo,UrunAdet,SKT,Aciklama,Sifrelenen,Cozulen) " +
                        "VALUES (@urunAdi,@urunNerede,@takipNo,@urunAdet,@skt,@aciklama,@sifrelenen,@cozulen)", genelSinif.conn);
                    int sayac = 0;
                    Random rnd = new Random();
                    int RandomTakipNo = rnd.Next(10000, 100000);
                    while (sayac < 1)
                    {

                        OleDbCommand cmd2 = new OleDbCommand("select TakipNo from Tedarik where TakipNo = @RandomTakipNo", genelSinif.conn);
                        cmd2.Parameters.AddWithValue("@RandomTakipNo", RandomTakipNo);
                        OleDbDataReader dr = cmd2.ExecuteReader();
                        if (dr.Read())
                        {
                            RandomTakipNo = rnd.Next(1, 1000);
                        }
                        else
                        {
                            sayac++;
                        }

                    }
                    cmd.Parameters.AddWithValue("@urunAdi", urunAdiTB.Text);
                    cmd.Parameters.AddWithValue("@urunNerede", urunNeredeCB.Text.ToString());
                    cmd.Parameters.AddWithValue("@takipNo", RandomTakipNo);
                    cmd.Parameters.AddWithValue("@urunAdet", urunAdetTB.Text);
                    cmd.Parameters.AddWithValue("@skt", sktDTP.Text.ToString());
                    cmd.Parameters.AddWithValue("@aciklama", aciklamaRTB.Text);
                    cmd.Parameters.AddWithValue("@sifrelenen", sifrelenenTB.Text);
                    cmd.Parameters.AddWithValue("@cozulen", decryptText);
                    cmd.ExecuteNonQuery();
                    TabloDoldur();
                }
            }
            else if (guncelleRB.Checked)
            {
                if (String.IsNullOrEmpty(urunAdiTB.Text))
                {
                    MessageBox.Show("Ürün Adı bilgisi boş olamaz.");
                }
                else if (String.IsNullOrEmpty(urunNeredeCB.Text))
                {
                    MessageBox.Show("Ürünün Nerede olduğu bilgisi boş olamaz");
                }
                else if (String.IsNullOrEmpty(urunAdetTB.Text))
                {
                    MessageBox.Show("Ürün Adet bilgisi boş olamaz.");
                }
                else if (String.IsNullOrEmpty(aciklamaRTB.Text))
                {
                    MessageBox.Show("Açıklama bilgisi boş olamaz");
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE Tedarik SET UrunAdi=@urunAdi,UrunNerede=@urunNerede,UrunAdet=@urunAdet,Aciklama=@aciklama where urunAdi=@UrunAdi", genelSinif.conn);
                    cmd.Parameters.AddWithValue("@urunAdi", urunAdiTB.Text);
                    cmd.Parameters.AddWithValue("@urunNerede", urunNeredeCB.Text);
                    cmd.Parameters.AddWithValue("@urunAdet", urunAdetTB.Text);
                    cmd.Parameters.AddWithValue("@aciklama", aciklamaRTB.Text.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün Güncellendi");
                    TabloDoldur();
                }
            }
            
        }

        private void YoneticiTedarikKontrol_Load(object sender, EventArgs e)
        {
            ButonFalse();
            TabloDoldur();
            
        }

        private void ekleRB_CheckedChanged(object sender, EventArgs e)
        {
            ButonFalse();
            button1.Text = "Ürün Tedarik Ekle";
            button1.Enabled = true;
            urunAdiTB.Enabled = true;
            urunAdetTB.Enabled = true;
            urunNeredeCB.Enabled = true;
            aciklamaRTB.Enabled = true;
            sktDTP.Enabled = true;
            sifrelenenTB.Enabled = true;
        }

        private void guncelleRB_CheckedChanged(object sender, EventArgs e)
        {
            ButonFalse();
            button1.Text = "Ürün Tedarik Güncelle";
            button1.Enabled = true;
            urunAdiTB.Enabled = true;
            urunAdetTB.Enabled = true;
            urunNeredeCB.Enabled = true;
            aciklamaRTB.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            genelSinif.baglanti();
            OleDbDataAdapter da = new OleDbDataAdapter("select TakipNo,UrunAdi,UrunNerede,UrunAdet,SKT,Aciklama from Tedarik where TakipNo = '" + takipNoAra.Text + "'", genelSinif.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tedarik");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            genelSinif.baglanti();
            OleDbDataAdapter da = new OleDbDataAdapter("select TakipNo,UrunAdi,UrunNerede,UrunAdet,SKT,Aciklama from Tedarik where UrunAdi = '" + urunAdiAra.Text + "'", genelSinif.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tedarik");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

