using System;

namespace Kampintro1
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Eray";
            int yas = 18;
            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "c#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.İzlenmeOranı = "68";

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "java";
            kurs2.Eğitmen = "Safa";
            kurs2.İzlenmeOranı = "48";

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "python";
            kurs3.Eğitmen = "Eray ";
            kurs3.İzlenmeOranı = "75";

            //  Console.WriteLine(kurs1.Kursadi + " " + kurs1.Eğitmen );


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Eğitmen);

            }
        }
    }
    public class Kurs
    {
        public string Kursadi { get; set; }

        public string Eğitmen { get; set; }

        public string İzlenmeOranı { get; set; }
    }
}
