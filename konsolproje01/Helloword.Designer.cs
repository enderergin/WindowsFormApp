namespace konsolproje01
{
    partial class Helloword
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
            this.gosterilenMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gosterilenMesaj
            // 
            this.gosterilenMesaj.AutoSize = true;
            this.gosterilenMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gosterilenMesaj.Location = new System.Drawing.Point(221, 151);
            this.gosterilenMesaj.MaximumSize = new System.Drawing.Size(5000, 100);
            this.gosterilenMesaj.Name = "gosterilenMesaj";
            this.gosterilenMesaj.Size = new System.Drawing.Size(310, 39);
            this.gosterilenMesaj.TabIndex = 0;
            this.gosterilenMesaj.Text = "merhaba buradasın";
            this.gosterilenMesaj.Click += new System.EventHandler(this.label1_Click);
            // 
            // Helloword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gosterilenMesaj);
            this.Name = "Helloword";
            this.Text = "Helloword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gosterilenMesaj;
    }
}