using System;

namespace CS014SoucetPrvocisel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Součet prvních 500 prvočísel:");
            long soucet = 0;
            int pocet = 0;
            int cislo = 2;
            while (pocet < 500)
            {
                if (JePrvocislo(cislo))
                {
                    soucet += cislo;
                    Console.WriteLine("Číslo: {0}\nSoučet: {1}\n", cislo, soucet);
                    pocet++;
                }
                cislo++;
            }
            Console.WriteLine("\nVýsledný součet: {0}",soucet);
            Console.ReadKey();
        }
        public static bool JePrvocislo(int cislo)
        {
            int x = (int)Math.Floor(Math.Sqrt(cislo));
            if (cislo == 1) return false;
            if (cislo == 2) return true;
            for (int i = 2; i <= x; i++)
                if (cislo % i == 0) return false;
            return true;
        }
    }
}
