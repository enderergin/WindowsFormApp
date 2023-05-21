namespace formproje02
{
    partial class PopForm
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
            this.Kullanıcı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kullanıcı
            // 
            this.Kullanıcı.AutoSize = true;
            this.Kullanıcı.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kullanıcı.Location = new System.Drawing.Point(347, 172);
            this.Kullanıcı.Name = "Kullanıcı";
            this.Kullanıcı.Size = new System.Drawing.Size(73, 25);
            this.Kullanıcı.TabIndex = 0;
            this.Kullanıcı.Text = "label1";
            this.Kullanıcı.Click += new System.EventHandler(this.Kullanıcı_Click);
            // 
            // PopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kullanıcı);
            this.Name = "PopForm";
            this.Text = "PopForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kullanıcı;
    }
}