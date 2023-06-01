namespace formapp02
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
            this.components = new System.ComponentModel.Container();
            this.YeniMusteriBox = new System.Windows.Forms.GroupBox();
            this.YeniMusteriList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSoyIsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.BtnMusteri = new System.Windows.Forms.Button();
            this.listMusteri = new System.Windows.Forms.ListBox();
            this.Balon = new System.Windows.Forms.NotifyIcon(this.components);
            this.YeniMusteriBox.SuspendLayout();
            this.YeniMusteriList.SuspendLayout();
            this.SuspendLayout();
            // 
            // YeniMusteriBox
            // 
            this.YeniMusteriBox.Controls.Add(this.BtnMusteri);
            this.YeniMusteriBox.Controls.Add(this.textEmail);
            this.YeniMusteriBox.Controls.Add(this.label4);
            this.YeniMusteriBox.Controls.Add(this.textTel);
            this.YeniMusteriBox.Controls.Add(this.label3);
            this.YeniMusteriBox.Controls.Add(this.textSoyIsim);
            this.YeniMusteriBox.Controls.Add(this.label2);
            this.YeniMusteriBox.Controls.Add(this.textIsim);
            this.YeniMusteriBox.Controls.Add(this.label1);
            this.YeniMusteriBox.Location = new System.Drawing.Point(12, 12);
            this.YeniMusteriBox.Name = "YeniMusteriBox";
            this.YeniMusteriBox.Size = new System.Drawing.Size(256, 217);
            this.YeniMusteriBox.TabIndex = 0;
            this.YeniMusteriBox.TabStop = false;
            this.YeniMusteriBox.Text = "Yeni Musteri Ekleme";
            // 
            // YeniMusteriList
            // 
            this.YeniMusteriList.Controls.Add(this.listMusteri);
            this.YeniMusteriList.Location = new System.Drawing.Point(274, 12);
            this.YeniMusteriList.Name = "YeniMusteriList";
            this.YeniMusteriList.Size = new System.Drawing.Size(313, 237);
            this.YeniMusteriList.TabIndex = 1;
            this.YeniMusteriList.TabStop = false;
            this.YeniMusteriList.Text = "Yeni Musteri Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textIsim
            // 
            this.textIsim.Location = new System.Drawing.Point(92, 30);
            this.textIsim.Name = "textIsim";
            this.textIsim.Size = new System.Drawing.Size(164, 22);
            this.textIsim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // textSoyIsim
            // 
            this.textSoyIsim.Location = new System.Drawing.Point(92, 58);
            this.textSoyIsim.Name = "textSoyIsim";
            this.textSoyIsim.Size = new System.Drawing.Size(164, 22);
            this.textSoyIsim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(92, 86);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(164, 22);
            this.textTel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(92, 114);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(164, 22);
            this.textEmail.TabIndex = 3;
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Location = new System.Drawing.Point(106, 154);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(137, 23);
            this.BtnMusteri.TabIndex = 4;
            this.BtnMusteri.Text = "Yeni Musteri Ekle";
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // listMusteri
            // 
            this.listMusteri.FormattingEnabled = true;
            this.listMusteri.ItemHeight = 16;
            this.listMusteri.Location = new System.Drawing.Point(6, 33);
            this.listMusteri.Name = "listMusteri";
            this.listMusteri.Size = new System.Drawing.Size(302, 196);
            this.listMusteri.TabIndex = 0;
            this.listMusteri.SelectedIndexChanged += new System.EventHandler(this.listMusteri_SelectedIndexChanged);
            // 
            // Balon
            // 
            this.Balon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.YeniMusteriList);
            this.Controls.Add(this.YeniMusteriBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Massage Box Uygulaması";
            this.YeniMusteriBox.ResumeLayout(false);
            this.YeniMusteriBox.PerformLayout();
            this.YeniMusteriList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox YeniMusteriBox;
        private System.Windows.Forms.GroupBox YeniMusteriList;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSoyIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMusteri;
        private System.Windows.Forms.ListBox listMusteri;
        private System.Windows.Forms.NotifyIcon Balon;
    }
}

