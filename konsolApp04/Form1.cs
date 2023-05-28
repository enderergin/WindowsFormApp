using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konsolApp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void YeniMusterBTN_Click(object sender, EventArgs e)
        {
           int sonuc = musteriEKleme(new musteri()
            {
                id = Guid.NewGuid(), // id ye özel tek olacak şekilde değer veriyor
                isim = isimTexbox.Text,
                soyisim = soyisimTexBox.Text,
                telefonNo = telefonNoBox.Text,
                email = emailBox.Text
            });
            if (sonuc>0)
            {
                DialogResult res = MessageBox.Show("Müsteri eklendi yeni, müsteri eklemek siter misiniz ? ","bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                if (res == DialogResult.Yes )
                {
                    Bilgilendirme = new NotifyIcon();
                    Bilgilendirme.BalloonTipText = "Müsteri kayit adeti" + database.list.Count.ToString();
                    Bilgilendirme.BalloonTipTitle = "Müsteri adet bilgisi" + database.list.Count.ToString();
                    Bilgilendirme.Visible = true; // ekranda görüneceğini belirliyon
                    Bilgilendirme.Icon = SystemIcons.Information; // icon seçiyon
                    Bilgilendirme.ShowBalloonTip(3000); // ekranda kaç sn kalacağını belirliyorsun
                }
                else if(res == DialogResult.No)
                {

                }
                EkranTemizleme();
                ekranayaz();
            }
            else
            {
                MessageBox.Show("Yeni musteri eklenemedi Bilgilerinizi Kontrol edin");
            }
        }
        private void ekranayaz()
        {
            listMusteri.DataSource = database.list; //database deki list koleksiyonunu ekrana yazıyor
        }
        private void EkranTemizleme() // Text leri siliyor 
        {
            isimTexbox.Text = string.Empty;
            soyisimTexBox.Text = string.Empty;
            telefonNoBox.Text = string.Empty;
            emailBox.Text = string.Empty;
        }
        private int musteriEKleme(musteri data) 
        {
            database.list.Add(data);
            return 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
