using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //gerçek müşteride bir müşteridir demek. miras alma.
    //müşteride olan her şey gerçek müşteride de kabul edilir.
    class GercekMusteri : Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
