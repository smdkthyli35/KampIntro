using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // Bir classın sonunda manager, service, dal(data access), controller gibi
        // ifadeler görürsek anlamı bunlar bir operasyon tutuyor demektir.

        //naming convention - isimlendirme kuralı
        //syntax - yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2()
        {

        }
    }
}
