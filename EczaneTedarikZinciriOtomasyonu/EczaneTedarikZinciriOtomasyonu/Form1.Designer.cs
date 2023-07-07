namespace EczaneTedarikZinciriOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.YoneticiButon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YoneticiButon
            // 
            this.YoneticiButon.ImageIndex = 0;
            this.YoneticiButon.Location = new System.Drawing.Point(162, 76);
            this.YoneticiButon.Name = "YoneticiButon";
            this.YoneticiButon.Size = new System.Drawing.Size(139, 61);
            this.YoneticiButon.TabIndex = 0;
            this.YoneticiButon.Text = "Yönetici Girişi";
            this.YoneticiButon.UseVisualStyleBackColor = true;
            this.YoneticiButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kullanıcı Girişi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.YoneticiButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YoneticiButon;
        private System.Windows.Forms.Button button2;
    }
}

