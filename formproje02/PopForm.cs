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
    public partial class PopForm : Form
    {
        public PopForm(kullanıcı kullaniciAdi)
        {
            InitializeComponent();
            string s1 = kullaniciAdi.isim;
            string s2 = "Hoş geldin";
            Kullanıcı.Text = s2 + " " + s1;
            
        }

        private void Kullanıcı_Click(object sender, EventArgs e)
        {

        }
    }
}
