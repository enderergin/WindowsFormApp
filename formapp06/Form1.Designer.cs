namespace formapp06
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.UrunAdi = new System.Windows.Forms.TextBox();
            this.Katogori = new System.Windows.Forms.TextBox();
            this.StokAdet = new System.Windows.Forms.TextBox();
            this.Yazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Acıklama = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Listesi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Acıklama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Yazar);
            this.groupBox1.Controls.Add(this.StokAdet);
            this.groupBox1.Controls.Add(this.Katogori);
            this.groupBox1.Controls.Add(this.UrunAdi);
            this.groupBox1.Controls.Add(this.Resim);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 403);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Resim
            // 
            this.Resim.Location = new System.Drawing.Point(6, 21);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(100, 128);
            this.Resim.TabIndex = 3;
            this.Resim.TabStop = false;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Location = new System.Drawing.Point(191, 21);
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(158, 22);
            this.UrunAdi.TabIndex = 4;
            // 
            // Katogori
            // 
            this.Katogori.Location = new System.Drawing.Point(191, 49);
            this.Katogori.Name = "Katogori";
            this.Katogori.Size = new System.Drawing.Size(158, 22);
            this.Katogori.TabIndex = 4;
            this.Katogori.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // StokAdet
            // 
            this.StokAdet.Location = new System.Drawing.Point(191, 77);
            this.StokAdet.Name = "StokAdet";
            this.StokAdet.Size = new System.Drawing.Size(158, 22);
            this.StokAdet.TabIndex = 4;
            // 
            // Yazar
            // 
            this.Yazar.Location = new System.Drawing.Point(191, 105);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(158, 22);
            this.Yazar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürüm Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Katoğori";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stok Adet";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yazar";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // Acıklama
            // 
            this.Acıklama.Location = new System.Drawing.Point(22, 174);
            this.Acıklama.Name = "Acıklama";
            this.Acıklama.Size = new System.Drawing.Size(327, 134);
            this.Acıklama.TabIndex = 6;
            this.Acıklama.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Yazar;
        private System.Windows.Forms.TextBox StokAdet;
        private System.Windows.Forms.TextBox Katogori;
        private System.Windows.Forms.TextBox UrunAdi;
        private System.Windows.Forms.PictureBox Resim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Acıklama;
    }
}

