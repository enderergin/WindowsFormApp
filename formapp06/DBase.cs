using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formapp06
{
    public class DBase
    {
        public static List<Urun> list = new List<Urun>()
        {
            new Urun() { id = 1, urunAdet = 20, urunKatogori = "Roman1", acıklama = "Açıklama1", yazar = "ender1", urunADİ="kervan1",urunResim = "C:\\Users\\CASPER\\Downloads\\sınavlar\\1.jpeg" },
            new Urun() {id = 2, urunAdet = 20, urunKatogori = "Roman2", acıklama = "Açıklama2", yazar = "ender2", urunADİ="kervan2",urunResim = "C:\\Users\\CASPER\\Downloads\\sınavlar\\2.jpg"},
            new Urun() {id = 3, urunAdet = 20, urunKatogori = "Roman3", acıklama = "Açıklama3", yazar = "ender3", urunADİ = "kervan3", urunResim = "C:\\Users\\CASPER\\Downloads\\sınavlar\\3.png"},
            new Urun() {id = 4, urunAdet = 20, urunKatogori = "Roman4", acıklama = "Açıklama4", yazar = "ender4", urunADİ="kervan4",urunResim = "C:\\Users\\CASPER\\Downloads\\sınavlar\\4.jpeg"},

        };

    }
}
