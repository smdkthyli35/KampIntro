using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan
        //durumlar için kullanırız.  
        //interface'ler newlenemez!
        void Hesapla();
        void BiseyYap();

    }
}
