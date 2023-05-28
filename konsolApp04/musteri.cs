using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolApp04
{
    public class musteri
    {
        //char emailkontrol = '@';
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set;}
        public string telefonNo { get; set;}
        public Guid id { get; set;}

        //public musteri()
        //{
        //    int k1 = email.IndexOf(emailkontrol);
        //    if (k1 != -1)
        //    {
        //        Console.WriteLine("Lütfen buraya e mail adreisnizi giriniz"); burayı bir bilene sor
        //    }
        //}

        public override string ToString() // arkaplandaki ToString'i çağırıyor Eğer override etmezsen class ve proje ismini yazar override ile eziyorsun return ile geri döndürüyorsun
        {
            return isim + " " + soyisim;
        }
    }
}
