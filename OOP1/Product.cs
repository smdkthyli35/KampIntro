using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity
    {
        //Bu tip classlarda sadece özellik olur.
        //snippet - hazır kodlar
        public int Id { get; set; }
        public int CategoryId { get; set; } // referans anahtarlar ikinci sıraya yazılır. ( kod okunurluğunu artırmak için)
        
        //ürün ismi
        public string ProductName { get; set; }
        
        //ürün fiyatı
        public double UnitPrice { get; set; }
        
        //ürün stok adeti
        public int UnitsInStock { get; set; }

        //CRUD - Create Read Update Delete - Eklemek Okumak Güncellemek Silmek

    }
}
