using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formapp02
{
    public class Databasee
    {
        public static List<Musteri> Musterilist { get; set; }

        static Databasee()
        {
            Musterilist = new List<Musteri>();
        }
    }
    
    
}
