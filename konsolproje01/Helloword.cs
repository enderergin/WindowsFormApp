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
    public partial class Helloword : Form
    {
        public Helloword(string labeldeger)
        {
            InitializeComponent();
            gosterilenMesaj.Text = labeldeger;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
