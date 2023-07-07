namespace EczaneTedarikZinciriOtomasyonu
{
    partial class KullaniciYonetimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcknTB = new System.Windows.Forms.TextBox();
            this.kulAdiTB = new System.Windows.Forms.TextBox();
            this.sifreTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ekleRB = new System.Windows.Forms.RadioButton();
            this.silRB = new System.Windows.Forms.RadioButton();
            this.guncelleRB = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(937, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TCKN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // tcknTB
            // 
            this.tcknTB.Location = new System.Drawing.Point(130, 84);
            this.tcknTB.Name = "tcknTB";
            this.tcknTB.Size = new System.Drawing.Size(153, 20);
            this.tcknTB.TabIndex = 3;
            // 
            // kulAdiTB
            // 
            this.kulAdiTB.Location = new System.Drawing.Point(130, 110);
            this.kulAdiTB.Name = "kulAdiTB";
            this.kulAdiTB.Size = new System.Drawing.Size(153, 20);
            this.kulAdiTB.TabIndex = 4;
            // 
            // sifreTB
            // 
            this.sifreTB.Location = new System.Drawing.Point(130, 136);
            this.sifreTB.Name = "sifreTB";
            this.sifreTB.Size = new System.Drawing.Size(153, 20);
            this.sifreTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // ekleRB
            // 
            this.ekleRB.AutoSize = true;
            this.ekleRB.Location = new System.Drawing.Point(130, 54);
            this.ekleRB.Name = "ekleRB";
            this.ekleRB.Size = new System.Drawing.Size(102, 17);
            this.ekleRB.TabIndex = 10;
            this.ekleRB.TabStop = true;
            this.ekleRB.Text = "Kullanıcı Ekleme";
            this.ekleRB.UseVisualStyleBackColor = true;
            this.ekleRB.CheckedChanged += new System.EventHandler(this.ekleRB_CheckedChanged);
            // 
            // silRB
            // 
            this.silRB.AutoSize = true;
            this.silRB.Location = new System.Drawing.Point(258, 54);
            this.silRB.Name = "silRB";
            this.silRB.Size = new System.Drawing.Size(92, 17);
            this.silRB.TabIndex = 11;
            this.silRB.TabStop = true;
            this.silRB.Text = "Kullanıcı Silme";
            this.silRB.UseVisualStyleBackColor = true;
            this.silRB.CheckedChanged += new System.EventHandler(this.silRB_CheckedChanged);
            // 
            // guncelleRB
            // 
            this.guncelleRB.AutoSize = true;
            this.guncelleRB.Location = new System.Drawing.Point(383, 54);
            this.guncelleRB.Name = "guncelleRB";
            this.guncelleRB.Size = new System.Drawing.Size(123, 17);
            this.guncelleRB.TabIndex = 12;
            this.guncelleRB.TabStop = true;
            this.guncelleRB.Text = "Kullanıcı Güncelleme";
            this.guncelleRB.UseVisualStyleBackColor = true;
            this.guncelleRB.CheckedChanged += new System.EventHandler(this.guncelleRB_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "İşlem";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "İşleminizi Seçiniz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(898, 220);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Çıkış Yap";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(837, 191);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 13);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Yönetici Paneline Dön";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // KullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 570);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guncelleRB);
            this.Controls.Add(this.silRB);
            this.Controls.Add(this.ekleRB);
            this.Controls.Add(this.sifreTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kulAdiTB);
            this.Controls.Add(this.tcknTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullaniciYonetimi";
            this.Text = "KullaniciYonetimi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciYonetimi_FormClosing);
            this.Load += new System.EventHandler(this.KullaniciYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcknTB;
        private System.Windows.Forms.TextBox kulAdiTB;
        private System.Windows.Forms.TextBox sifreTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ekleRB;
        private System.Windows.Forms.RadioButton silRB;
        private System.Windows.Forms.RadioButton guncelleRB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}