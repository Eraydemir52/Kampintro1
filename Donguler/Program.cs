using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "kurs1", "kurs2", "java" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurslar1 in kurslar)
            {
                Console.WriteLine(kurslar1);
            }
        }
    }
}
