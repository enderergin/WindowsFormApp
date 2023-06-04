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
    public partial class kayitOnizleme : Form
    {
        public kayitOnizleme()
        {
            InitializeComponent();
        }

        private void textSoyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIsim_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydett_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "Form1")
                {
                    foreach (Control Formitem in item.Controls)
                    {
                        if (Formitem is TextBox)
                        {
                            Formitem.Text = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
