using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApp07
{
    public partial class KullaniciUrunSecim : Form
    {
        Urun[] urunlist;
        public KullaniciUrunSecim(Urun[] SecilenUrunler)
        {
            InitializeComponent();
            urunlist = SecilenUrunler;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KullaniciUrunSecim_Load(object sender, EventArgs e)
        {
            foreach (var item in urunlist)
            {
                Button button = new Button();
                button.Text = item.urunADİ;
                button.Name = "UrunADİ" + item.id.ToString();
                button.Size = new System.Drawing.Size(174, 46);
                button.Tag = item;
                button.Click += button_Click;
                flowLayoutPanel1.Controls.Add(button);

            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Urun u1 = (Urun)btn.Tag;
            Form f1 = Application.OpenForms["Form1"];
            GroupBox f1box = (GroupBox)f1.Controls["groupBox1"];
            ((PictureBox)f1box.Controls["Resim"]).Image = Image.FromFile(u1.urunResim);
            ((TextBox)f1box.Controls["UrunAdi"]).Text = u1.urunADİ.ToString();
            ((TextBox)f1box.Controls["Katogori"]).Text = u1.urunKatogori;
            ((TextBox)f1box.Controls["StokAdet"]).Text = u1.urunAdet.ToString();
            ((TextBox)f1box.Controls["Yazar"]).Text = u1.yazar;
            ((RichTextBox)f1box.Controls["Acıklama"]).Text = u1.acıklama;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
