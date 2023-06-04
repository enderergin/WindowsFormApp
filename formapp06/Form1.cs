using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formapp06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CombaDoldur();
            CombaDoldur1(); // combaDoldur ve combaDoldur1 ikiside aynı işi yapıyor
        }
        void CombaDoldur1()
        {
            comboBox1.DataSource = DBase.list;
        }
        void CombaDoldur()
        {
            foreach (object item in DBase.list)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object o1 = comboBox1.SelectedItem;
            Urun TiklananIndex = (Urun)o1; //comboBox'un içinde tıklanan değeri döndürüyor
            Resim.Image = Image.FromFile(TiklananIndex.urunResim);
            Resim.SizeMode = PictureBoxSizeMode.StretchImage;

            UrunAdi.Text = TiklananIndex.urunADİ;
            Katogori.Text = TiklananIndex.urunKatogori;
            StokAdet.Text = TiklananIndex.urunAdet.ToString();
            Acıklama.Text = TiklananIndex.acıklama;
            Yazar.Text = TiklananIndex.yazar;


        }
    }
}
