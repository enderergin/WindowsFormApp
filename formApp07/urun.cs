using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formApp07
{
    public class Urun
    {
        public int id { get; set; }
        public string urunADİ { get; set; }
        public String urunResim { get; set; }
        public string urunKatogori { get; set; }
        public string yazar { get; set; }
        public string acıklama { get; set; }
        public int urunAdet { get; set; }

        //public override string ToString()
        //{
        //    return urunADİ + " " + yazar;
        //}
    }

}
