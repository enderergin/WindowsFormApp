using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formapp02
{
    public class Musteri
    {
        public Guid id { get; set; }
        public string _isim { get; set; }
        public string _soyisim { get; set; }
        public string _email { get; set; }
        public string _phone { get; set; }
        public override string ToString()
        {
            return _isim + " " + _soyisim;
        }

    }
}
