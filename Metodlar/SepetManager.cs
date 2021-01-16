using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //name convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urun.Adi);


        }

        public void Ekle2(string urunAdi, String aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urunAdi);
        }

    }
}
