namespace formapp04
{
    partial class kayitOnizleme
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
            this.textTel = new System.Windows.Forms.TextBox();
            this.textIsim = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydett = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTel
            // 
            this.textTel.Enabled = false;
            this.textTel.Location = new System.Drawing.Point(26, 152);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(100, 22);
            this.textTel.TabIndex = 10;
            this.textTel.TextChanged += new System.EventHandler(this.textTel_TextChanged);
            // 
            // textIsim
            // 
            this.textIsim.Enabled = false;
            this.textIsim.Location = new System.Drawing.Point(26, 22);
            this.textIsim.Name = "textIsim";
            this.textIsim.Size = new System.Drawing.Size(100, 22);
            this.textIsim.TabIndex = 8;
            this.textIsim.TextChanged += new System.EventHandler(this.textIsim_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.Enabled = false;
            this.textEmail.Location = new System.Drawing.Point(26, 216);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 22);
            this.textEmail.TabIndex = 11;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textSoyisim
            // 
            this.textSoyisim.Enabled = false;
            this.textSoyisim.Location = new System.Drawing.Point(26, 86);
            this.textSoyisim.Name = "textSoyisim";
            this.textSoyisim.Size = new System.Drawing.Size(100, 22);
            this.textSoyisim.TabIndex = 9;
            this.textSoyisim.TextChanged += new System.EventHandler(this.textSoyisim_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "telefon";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "soyisim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKaydett
            // 
            this.btnKaydett.Location = new System.Drawing.Point(162, 58);
            this.btnKaydett.Name = "btnKaydett";
            this.btnKaydett.Size = new System.Drawing.Size(107, 146);
            this.btnKaydett.TabIndex = 12;
            this.btnKaydett.Text = "Kaydet";
            this.btnKaydett.UseVisualStyleBackColor = true;
            this.btnKaydett.Click += new System.EventHandler(this.btnKaydett_Click);
            // 
            // kayitOnizleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 350);
            this.Controls.Add(this.btnKaydett);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textIsim);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textSoyisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayitOnizleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit Ön İzleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textIsim;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSoyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydett;
    }
}