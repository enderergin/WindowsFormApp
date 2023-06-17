using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApp08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void checkedListBox1Doldur()
        {
            foreach (var item in BaseClass.list)
            {
                chkListBox.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1Doldur();

        }

        private void chkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox c1 = (CheckedListBox)sender;
            if (e.NewValue == CheckState.Checked)
            {
                Urun secilenUrun = c1.Items[e.Index] as Urun;
                Resim.Image = Image.FromFile(secilenUrun.urunResim);
                Resim.SizeMode = PictureBoxSizeMode.StretchImage;
                UrunAdi.Text = secilenUrun.urunADİ;
                Katogori.Text = secilenUrun.urunKatogori;
                StokAdet.Text = secilenUrun.urunAdet.ToString();
                txtYazar.Text = secilenUrun.yazar;
                txtAcıklama.Text = secilenUrun.acıklama;

            }
        }
    }
}
