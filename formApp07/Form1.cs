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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int urunSecimAdet = listBox1.SelectedItems.Count;
            if (urunSecimAdet == 1)
            {


                ListBox list1 = (ListBox)sender;
                Urun u1 = (Urun)list1.SelectedItem;
                Resim.Image = Image.FromFile(u1.urunResim);
                Resim.SizeMode = PictureBoxSizeMode.StretchImage;

                UrunAdi.Text = u1.urunADİ;
                Katogori.Text = u1.urunKatogori;
                StokAdet.Text = u1.urunAdet.ToString();
                Acıklama.Text = u1.acıklama;
                Yazar.Text = u1.yazar;
            }
            else if (urunSecimAdet >1)
            {
                List<Urun> secilenUrunlist = new List<Urun>();
                foreach (var item in listBox1.SelectedItems)
                {
                    secilenUrunlist.Add(item as  Urun);
                }
                KullaniciUrunSecim KullaniciSecim = new KullaniciUrunSecim(secilenUrunlist.ToArray());
                KullaniciSecim.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen birini seçiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listdoldur2();
        }
        //void listdoldur()
        //{
        //    foreach (var item in DBase.list)
        //    {
        //        listBox1.Items.Add(item); 
        //    }
        //}
        void listdoldur2() // listdoldur ile aynı işi yapıyor 
        {
            listBox1.DisplayMember = "urunADİ"; // listbox'ta urun class'ındaki overrite to.string yerine kullanabiliyorsun 
            listBox1.DataSource = DBase.list;
 
        }
    }
}
