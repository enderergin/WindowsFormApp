namespace konsolApp04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YeniMusterBTN = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.telefonNoBox = new System.Windows.Forms.TextBox();
            this.TelefonNumarasilabel = new System.Windows.Forms.Label();
            this.soyisimTexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isimTexbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.musreriList = new System.Windows.Forms.GroupBox();
            this.listMusteri = new System.Windows.Forms.ListBox();
            this.Bilgilendirme = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.musreriList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YeniMusterBTN);
            this.groupBox1.Controls.Add(this.emailBox);
            this.groupBox1.Controls.Add(this.emaillabel);
            this.groupBox1.Controls.Add(this.telefonNoBox);
            this.groupBox1.Controls.Add(this.TelefonNumarasilabel);
            this.groupBox1.Controls.Add(this.soyisimTexBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.isimTexbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müsteri Ekleme";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // YeniMusterBTN
            // 
            this.YeniMusterBTN.Location = new System.Drawing.Point(192, 120);
            this.YeniMusterBTN.Name = "YeniMusterBTN";
            this.YeniMusterBTN.Size = new System.Drawing.Size(133, 37);
            this.YeniMusterBTN.TabIndex = 4;
            this.YeniMusterBTN.Text = "Yeni Müsteri";
            this.YeniMusterBTN.UseVisualStyleBackColor = true;
            this.YeniMusterBTN.Click += new System.EventHandler(this.YeniMusterBTN_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(14, 199);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 3;
            this.emailBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emaillabel.Location = new System.Drawing.Point(10, 176);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(66, 20);
            this.emaillabel.TabIndex = 0;
            this.emaillabel.Text = "e mail ";
            // 
            // telefonNoBox
            // 
            this.telefonNoBox.Location = new System.Drawing.Point(14, 151);
            this.telefonNoBox.Name = "telefonNoBox";
            this.telefonNoBox.Size = new System.Drawing.Size(100, 22);
            this.telefonNoBox.TabIndex = 2;
            // 
            // TelefonNumarasilabel
            // 
            this.TelefonNumarasilabel.AutoSize = true;
            this.TelefonNumarasilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelefonNumarasilabel.Location = new System.Drawing.Point(10, 124);
            this.TelefonNumarasilabel.Name = "TelefonNumarasilabel";
            this.TelefonNumarasilabel.Size = new System.Drawing.Size(157, 20);
            this.TelefonNumarasilabel.TabIndex = 0;
            this.TelefonNumarasilabel.Text = "Telefon Numarasi";
            // 
            // soyisimTexBox
            // 
            this.soyisimTexBox.Location = new System.Drawing.Point(14, 99);
            this.soyisimTexBox.Name = "soyisimTexBox";
            this.soyisimTexBox.Size = new System.Drawing.Size(100, 22);
            this.soyisimTexBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // isimTexbox
            // 
            this.isimTexbox.Location = new System.Drawing.Point(14, 49);
            this.isimTexbox.Name = "isimTexbox";
            this.isimTexbox.Size = new System.Drawing.Size(100, 22);
            this.isimTexbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // musreriList
            // 
            this.musreriList.Controls.Add(this.listMusteri);
            this.musreriList.Location = new System.Drawing.Point(386, 0);
            this.musreriList.Name = "musreriList";
            this.musreriList.Size = new System.Drawing.Size(412, 451);
            this.musreriList.TabIndex = 1;
            this.musreriList.TabStop = false;
            this.musreriList.Text = "Müsteri Listesi";
            this.musreriList.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listMusteri
            // 
            this.listMusteri.FormattingEnabled = true;
            this.listMusteri.ItemHeight = 16;
            this.listMusteri.Location = new System.Drawing.Point(6, 26);
            this.listMusteri.Name = "listMusteri";
            this.listMusteri.Size = new System.Drawing.Size(353, 212);
            this.listMusteri.TabIndex = 0;
            // 
            // Bilgilendirme
            // 
            this.Bilgilendirme.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.musreriList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mesaage Box";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.musreriList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox musreriList;
        private System.Windows.Forms.TextBox isimTexbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox telefonNoBox;
        private System.Windows.Forms.Label TelefonNumarasilabel;
        private System.Windows.Forms.TextBox soyisimTexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button YeniMusterBTN;
        private System.Windows.Forms.ListBox listMusteri;
        private System.Windows.Forms.NotifyIcon Bilgilendirme;
    }
}

