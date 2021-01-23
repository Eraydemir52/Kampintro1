using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "Eray";
            gercekMusteri.Soyadi = "Demir";
            gercekMusteri.TcNo = "1234343242";



            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "54321";
            tuzelMusteri.SirketAdi = "Kodlama.İO";
            tuzelMusteri.VergiNo = "1233130";

            // Gerçek Müşteri- Tüzel Müşteri
            //SOLID

            Musteri musteri = new GercekMusteri();
            Musteri musteri1 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(gercekMusteri);
            customerManager.Ekle(tuzelMusteri);








        }
    }
}
