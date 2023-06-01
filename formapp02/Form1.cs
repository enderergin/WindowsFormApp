using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formapp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(Databasee.Musterilist);
        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
           int islemsonuc = yeniMusteriekleme(new Musteri()
            {
                id = Guid.NewGuid(),
                _isim = textIsim.Text,
                _soyisim = textSoyIsim.Text,
                _email = textEmail.Text,
                _phone = textTel.Text,
            });
            if (islemsonuc>0)
            {
               DialogResult res = MessageBox.Show("Müsteri ekeleme başarılı","Yeni müsteri eklemek istermisiniz ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    Balon = new NotifyIcon();
                    Balon.BalloonTipText = "Toplam sayi" + Databasee.Musterilist.Count.ToString();
                    Balon.BalloonTipTitle = "musteri adeti";
                    Balon.Visible = true;
                    Balon.Icon = SystemIcons.Information;
                    Balon.ShowBalloonTip(3000);
                }
                else if (res == DialogResult.No)
                {
                }
                ekranTemizle();
                ekranListele();
            
            }
            else
            {
                MessageBox.Show("hata: Kayit eklenemedi","Başarısız", MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
        }

        private void ekranTemizle()
        {
            textIsim.Text = string.Empty;
            textSoyIsim.Text = string.Empty;
            textTel.Text = string.Empty;
            textEmail.Text = string.Empty;
        }
        private int yeniMusteriekleme(Musteri data)
        {
            Databasee.Musterilist.Add(data);
            return 1;
        }
        private void ekranListele()
        {
            listMusteri.DataSource = Databasee.Musterilist;
        }
    }
}
