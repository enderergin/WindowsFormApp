using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formproje02
{
    public class database
    {
        public static List<kullanıcı> kullanicidata = new List<kullanıcı>();
        static database()
        {
            kullanicidata.Add(new kullanıcı() 
            {
                id = 1,
                isim = "end",
                soyisim = "ergin",
                KullaniciIsmi = "endrergn",
                tc = "15686179384",
                acıklama = "enderin profili "
            });
            kullanicidata.Add(new kullanıcı()
            {
                id = 2,
                isim = "ender",
                soyisim = "erginoviç",
                KullaniciIsmi ="casper",
                tc = "07",
                acıklama = "enderin profili2 "

            });
        }
    }
}
