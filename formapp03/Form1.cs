using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formapp03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            MusteriKayit musterilist = new MusteriKayit();
            musterilist.ShowDialog();
        }
    }
}
