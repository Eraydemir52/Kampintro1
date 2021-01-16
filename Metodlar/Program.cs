using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.Adi = "Elma";
            Urun1.Fiyat = 15;
            Urun1.Aciklama = "Amasya Elması";

            Urun Urun2 = new Urun();
            Urun2.Adi = "Karpuz";
            Urun2.Fiyat = 80;
            Urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { Urun1, Urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("**********************");

            }

            Console.WriteLine("*************Metotlar************");
            //instance
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(Urun1);
            sepetmanager.Ekle(Urun2);

            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 9);
            sepetmanager.Ekle2("Elma", "Yeşil Elma", 12, 6);
            sepetmanager.Ekle2("Karpuz", "Diyar bakır karpuzu", 12, 8);

        }
    }
}
