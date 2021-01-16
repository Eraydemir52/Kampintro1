using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -tipgüvenliği
            //Do not repeat yourself
            string Katagorietikedi = "Katagori1";
            int ogrencisayısı = 32000;
            double faizoranı = 1.45;
            bool sistemegirişyapmışmı = false;
            double dolardun = 7.35;
            double dolarbugun = 7.45;
            if (dolardun > dolarbugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarbugun > dolardun)
            {
                Console.WriteLine("Artış oku");

            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemegirişyapmışmı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş butonu");
            }


        }
    }
}
