namespace EczaneTedarikZinciriOtomasyonu
{
    partial class KullaniciGirisi
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kulAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kulanıcı Adı";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(332, 180);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(173, 20);
            this.sifre.TabIndex = 8;
            // 
            // kulAdi
            // 
            this.kulAdi.Location = new System.Drawing.Point(332, 137);
            this.kulAdi.Name = "kulAdi";
            this.kulAdi.Size = new System.Drawing.Size(173, 20);
            this.kulAdi.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kulAdi);
            this.Controls.Add(this.button1);
            this.Name = "KullaniciGirisi";
            this.Text = "KullaniciGirisi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciGirisi_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox kulAdi;
        private System.Windows.Forms.Button button1;
    }
}