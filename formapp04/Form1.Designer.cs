namespace formapp04
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textIsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.Giris = new System.Windows.Forms.Button();
            this.btnonizleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "soyisim";
            // 
            // textSoyisim
            // 
            this.textSoyisim.Location = new System.Drawing.Point(25, 111);
            this.textSoyisim.Name = "textSoyisim";
            this.textSoyisim.Size = new System.Drawing.Size(100, 22);
            this.textSoyisim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "isim";
            // 
            // textIsim
            // 
            this.textIsim.Location = new System.Drawing.Point(25, 47);
            this.textIsim.Name = "textIsim";
            this.textIsim.Size = new System.Drawing.Size(100, 22);
            this.textIsim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "telefon";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(25, 241);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 22);
            this.textEmail.TabIndex = 4;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(25, 177);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(100, 22);
            this.textTel.TabIndex = 3;
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(156, 48);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(98, 87);
            this.Temizle.TabIndex = 6;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Giris
            // 
            this.Giris.Location = new System.Drawing.Point(156, 178);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(98, 87);
            this.Giris.TabIndex = 5;
            this.Giris.Text = "Giriş";
            this.Giris.UseVisualStyleBackColor = true;
            // 
            // btnonizleme
            // 
            this.btnonizleme.Location = new System.Drawing.Point(285, 113);
            this.btnonizleme.Name = "btnonizleme";
            this.btnonizleme.Size = new System.Drawing.Size(130, 89);
            this.btnonizleme.TabIndex = 7;
            this.btnonizleme.Text = "Ön İzleme";
            this.btnonizleme.UseVisualStyleBackColor = true;
            this.btnonizleme.Click += new System.EventHandler(this.btnonizleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 393);
            this.Controls.Add(this.btnonizleme);
            this.Controls.Add(this.Giris);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textIsim);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textSoyisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIsim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Giris;
        private System.Windows.Forms.Button btnonizleme;
    }
}

