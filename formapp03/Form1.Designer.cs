namespace formapp03
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
            this.Goster = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Goster
            // 
            this.Goster.Location = new System.Drawing.Point(27, 5);
            this.Goster.Name = "Goster";
            this.Goster.Size = new System.Drawing.Size(218, 88);
            this.Goster.TabIndex = 0;
            this.Goster.Text = "Göster";
            this.Goster.UseVisualStyleBackColor = true;
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(262, 5);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(218, 88);
            this.btnPop.TabIndex = 0;
            this.btnPop.Text = "Göster Popup";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.Goster);
            this.Name = "Form1";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Goster;
        private System.Windows.Forms.Button btnPop;
    }
}

