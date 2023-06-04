using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formapp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
          DialogResult res =  MessageBox.Show("Temizlemek İstediğinize eminmisiniz ?","Temizleme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Temizleme();
            }
            else if (res == DialogResult.No)
            {

            }
            
        }
        private void Temizleme()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.Text = string.Empty;

                }
                //((TextBox)this.Controls["textIsim"]).Text = string.Empty;
                //textIsim.Text = string.Empty; 

            }
        }

        private void btnonizleme_Click(object sender, EventArgs e)
        {
            kayitOnizleme Onizleme = new kayitOnizleme();
            ((TextBox)Onizleme.Controls["textIsim"]).Text = textIsim.Text;
            ((TextBox)Onizleme.Controls["textSoyisim"]).Text = textSoyisim.Text;
            ((TextBox)Onizleme.Controls["textTel"]).Text = textTel.Text;
            ((TextBox)Onizleme.Controls["textEmail"]).Text = textEmail.Text;
            Onizleme.ShowDialog();



        }
    }
}
