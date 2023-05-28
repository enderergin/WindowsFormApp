using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolApp04
{
    public class database:musteri
    {
        public static List<musteri> list = new List<musteri>();
        static database()
        {
            list = new List<musteri>();
        }
    }
}
