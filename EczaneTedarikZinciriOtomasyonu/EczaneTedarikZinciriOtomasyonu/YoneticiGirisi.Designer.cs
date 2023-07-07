namespace EczaneTedarikZinciriOtomasyonu
{
    partial class YoneticiGirisi
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
            this.button1 = new System.Windows.Forms.Button();
            this.kulAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GeriButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kulAdi
            // 
            this.kulAdi.Location = new System.Drawing.Point(333, 136);
            this.kulAdi.Name = "kulAdi";
            this.kulAdi.Size = new System.Drawing.Size(173, 20);
            this.kulAdi.TabIndex = 1;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(333, 179);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(173, 20);
            this.sifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kulanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // GeriButon
            // 
            this.GeriButon.Location = new System.Drawing.Point(7, 7);
            this.GeriButon.Name = "GeriButon";
            this.GeriButon.Size = new System.Drawing.Size(69, 34);
            this.GeriButon.TabIndex = 5;
            this.GeriButon.Text = "Geri Dön";
            this.GeriButon.UseVisualStyleBackColor = true;
            this.GeriButon.Click += new System.EventHandler(this.button2_Click);
            // 
            // YoneticiGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeriButon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kulAdi);
            this.Controls.Add(this.button1);
            this.Name = "YoneticiGirisi";
            this.Text = "Yönetici Giriş Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YoneticiGirisi_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kulAdi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GeriButon;
    }
}