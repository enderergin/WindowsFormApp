using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konsolproje01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Deger.Text = "Metin giriniz";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metindeger = Deger.Text;
            Helloword h1 = new Helloword(metindeger);
            h1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Deger_Enter(object sender, EventArgs e)
        {
            TextBox t1 =(TextBox)sender;
            t1.Text = string.Empty;

        }
    }
}
