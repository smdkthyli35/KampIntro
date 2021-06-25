using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            
            //Diziler çoğul isimlendirilir.
            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe - tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("-------------Metotlar-------------");

            //instance - class örneği oluşturmak
            //encapsulation     
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}

//Dont repeat yourself - DRY - Clean Code
//Best Practice - Doğru kod yazma teknikleri
//Classlar Pascal Case olarak yazılır. (Kelimeler bitişik ve ilk harfleri büyük olacak şekilde)

