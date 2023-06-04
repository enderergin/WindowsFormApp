using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formapp05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;
            Random rnd = new Random();
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 30);
            mayin3 = rnd.Next(31, 50);

            for (int i = 1; i <= 50; i++)
            { 
                Button butoUret = new Button();
                butoUret.Name = "BTN" + i.ToString();
                butoUret.Size = new Size(27,27);
                butoUret.Text = i.ToString();
                butoUret.UseVisualStyleBackColor = true;
                if (mayin1 == i || mayin2 == i || mayin3 == i)
                {
                    butoUret.Tag = true;
                }
                else
                {
                    butoUret.Tag = false;
                }
                butoUret.Tag = null;
                butoUret.Click += btnMayin;
                flowLayoutPanel1.Controls.Add(butoUret);
            }
        
        }
        private void btnMayin (object sender, EventArgs e)
        {
            Button basilanbuton = ((Button)sender);
            bool ButonBulundumu = (bool)basilanbuton.Tag;
            if (ButonBulundumu) 
            {
                MessageBox.Show("Mayına bastınız");
                basilanbuton.BackColor = Color.Red;
            }
            else
            {

                basilanbuton.BackColor= Color.Green;
            }
        }
    }
}
