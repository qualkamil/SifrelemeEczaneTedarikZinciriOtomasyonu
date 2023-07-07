namespace EczaneTedarikZinciriOtomasyonu
{
    partial class YoneticiTedarikKontrol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekleRB = new System.Windows.Forms.RadioButton();
            this.guncelleRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.urunAdiTB = new System.Windows.Forms.TextBox();
            this.urunAdetTB = new System.Windows.Forms.TextBox();
            this.urunNeredeCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.urunAdiAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.takipNoAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sktDTP = new System.Windows.Forms.DateTimePicker();
            this.aciklamaRTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sifrelenenTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // ekleRB
            // 
            this.ekleRB.AutoSize = true;
            this.ekleRB.Location = new System.Drawing.Point(103, 32);
            this.ekleRB.Name = "ekleRB";
            this.ekleRB.Size = new System.Drawing.Size(111, 17);
            this.ekleRB.TabIndex = 1;
            this.ekleRB.TabStop = true;
            this.ekleRB.Text = "Ürün Tedarik Ekle";
            this.ekleRB.UseVisualStyleBackColor = true;
            this.ekleRB.CheckedChanged += new System.EventHandler(this.ekleRB_CheckedChanged);
            // 
            // guncelleRB
            // 
            this.guncelleRB.AutoSize = true;
            this.guncelleRB.Location = new System.Drawing.Point(220, 32);
            this.guncelleRB.Name = "guncelleRB";
            this.guncelleRB.Size = new System.Drawing.Size(132, 17);
            this.guncelleRB.TabIndex = 2;
            this.guncelleRB.TabStop = true;
            this.guncelleRB.Text = "Ürün Tedarik Güncelle";
            this.guncelleRB.UseVisualStyleBackColor = true;
            this.guncelleRB.CheckedChanged += new System.EventHandler(this.guncelleRB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Nerede:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Adet:";
            // 
            // urunAdiTB
            // 
            this.urunAdiTB.Location = new System.Drawing.Point(103, 67);
            this.urunAdiTB.Name = "urunAdiTB";
            this.urunAdiTB.Size = new System.Drawing.Size(200, 20);
            this.urunAdiTB.TabIndex = 9;
            // 
            // urunAdetTB
            // 
            this.urunAdetTB.Location = new System.Drawing.Point(103, 127);
            this.urunAdetTB.Name = "urunAdetTB";
            this.urunAdetTB.Size = new System.Drawing.Size(200, 20);
            this.urunAdetTB.TabIndex = 10;
            // 
            // urunNeredeCB
            // 
            this.urunNeredeCB.FormattingEnabled = true;
            this.urunNeredeCB.Items.AddRange(new object[] {
            "Üretiliyor",
            "Üreticide",
            "Üreticiden Transfer Merkezine Yola Çıktı",
            "Transfer Merkezinde",
            "Transfer Merkezinden Alıcı\'ya Yola Çıktı",
            "Alıcı\'da"});
            this.urunNeredeCB.Location = new System.Drawing.Point(103, 97);
            this.urunNeredeCB.Name = "urunNeredeCB";
            this.urunNeredeCB.Size = new System.Drawing.Size(200, 21);
            this.urunNeredeCB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Açıklama:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "İşleminizi Seçiniz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "İşlem:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(673, 282);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 13);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Yönetici Paneline Dön";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(734, 311);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Çıkış Yap";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 39);
            this.button3.TabIndex = 30;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // urunAdiAra
            // 
            this.urunAdiAra.Location = new System.Drawing.Point(365, 173);
            this.urunAdiAra.Name = "urunAdiAra";
            this.urunAdiAra.Size = new System.Drawing.Size(179, 20);
            this.urunAdiAra.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ürün Adı ile Arama";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 39);
            this.button2.TabIndex = 27;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // takipNoAra
            // 
            this.takipNoAra.Location = new System.Drawing.Point(365, 83);
            this.takipNoAra.Name = "takipNoAra";
            this.takipNoAra.Size = new System.Drawing.Size(179, 20);
            this.takipNoAra.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Takip No ile Arama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "SKT:";
            // 
            // sktDTP
            // 
            this.sktDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sktDTP.Location = new System.Drawing.Point(103, 158);
            this.sktDTP.Name = "sktDTP";
            this.sktDTP.Size = new System.Drawing.Size(200, 20);
            this.sktDTP.TabIndex = 32;
            // 
            // aciklamaRTB
            // 
            this.aciklamaRTB.Location = new System.Drawing.Point(103, 190);
            this.aciklamaRTB.Name = "aciklamaRTB";
            this.aciklamaRTB.Size = new System.Drawing.Size(200, 20);
            this.aciklamaRTB.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Şifrelenen:";
            // 
            // sifrelenenTB
            // 
            this.sifrelenenTB.Location = new System.Drawing.Point(103, 222);
            this.sifrelenenTB.Name = "sifrelenenTB";
            this.sifrelenenTB.Size = new System.Drawing.Size(200, 20);
            this.sifrelenenTB.TabIndex = 36;
            // 
            // YoneticiTedarikKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 643);
            this.Controls.Add(this.sifrelenenTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aciklamaRTB);
            this.Controls.Add(this.sktDTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.urunAdiAra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.takipNoAra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.urunNeredeCB);
            this.Controls.Add(this.urunAdetTB);
            this.Controls.Add(this.urunAdiTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guncelleRB);
            this.Controls.Add(this.ekleRB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YoneticiTedarikKontrol";
            this.Text = "YoneticiTedarikKontrol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YoneticiTedarikKontrol_FormClosing);
            this.Load += new System.EventHandler(this.YoneticiTedarikKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton ekleRB;
        private System.Windows.Forms.RadioButton guncelleRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urunAdiTB;
        private System.Windows.Forms.TextBox urunAdetTB;
        private System.Windows.Forms.ComboBox urunNeredeCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox urunAdiAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox takipNoAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker sktDTP;
        private System.Windows.Forms.TextBox aciklamaRTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sifrelenenTB;
    }
}