using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formproje02
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = isim.Text.ToLower();
            string kullaniciSifre = sifre.Text;
            kullanıcı kontrol = database.kullanicidata.Find(i => i.KullaniciIsmi == kullaniciAdi && i.tc == kullaniciSifre);
            //kullaniciAdi == "ender" && kullaniciSifre == "123" || (kullaniciAdi == "admin" && kullaniciSifre == "321")
            if (kontrol != null)
            {
                
                PopForm p1 = new PopForm(kontrol);
                p1.Show();
            }
            else
            {
                MessageBox.Show("Senin gibi bir kullanıcı bulunamadı","Sen Kimsin", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void isim_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.BackColor = Color.Black;
        }

        private void isim_Leave(object sender, EventArgs e)
        {
            TextBox t2 = (TextBox)sender;
            t2.BackColor = Color.Blue;
        }
    }
}
 