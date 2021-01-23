using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // interfaceleri birbirinin alternetifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    // Log = Kim ne zaman hangi operasyonu çağırdı / o sistemde olan hareketleri gösterir
    interface IKrediManager
    {
       
        void Hesapla();
        void BiseyYap();
    }
}
