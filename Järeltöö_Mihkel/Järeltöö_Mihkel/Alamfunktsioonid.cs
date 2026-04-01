using System;
using System.Collections.Generic;
using System.Text;

namespace Järeltöö_Mihkel
{
    public class Alamfunktsioonid
    {
        public static void TaksoKalkulaator()
        {
            try
            {
                Console.Write("Sisesta sisseistumistasu (€): ");
                var sis = Console.ReadLine();
                double sisse = double.Parse(sis.Replace(',', '.'));

                Console.Write("Sisesta kilomeetri hind (€/km): ");
                var kph = Console.ReadLine();
                double kmhind = double.Parse(kph.Replace(',', '.'));

                Console.Write("Sisesta läbitud kilomeetrid (km): ");
                var kmd = Console.ReadLine();
                double km = double.Parse(kmd.Replace(',', '.'));

                double kokku = sisse + (kmhind * km);
                Console.WriteLine($"Kogu sõidu maksumus: {kokku:F2} €");
            }
            catch (Exception)
            {
                Console.WriteLine("Vigane sisend! Palun sisesta arvulised väärtused.");
            }
        }

        public static void HindaKellaaega()
        {
            Console.Write("Sisesta kellaaeg kujul HH:MM:SS: ");
            string s = Console.ReadLine() ?? string.Empty;
            if (s.Length != 8)
            {
                Console.WriteLine("Vigane kellaaja formaat!");
                return;
            }

            try
            {
                string tunnid = s.Substring(0, 2);
                string minutid = s.Substring(3, 2);
                string sekundid = s.Substring(6, 2);
                Console.WriteLine($"Kell on täpselt {tunnid} tundi, {minutid} minutit ja {sekundid} sekundit.");
            }
            catch (Exception)
            {
                Console.WriteLine("Vigane kellaaja formaat!");
            }
        }

        public static void TaringuStatistika()
        {
            var rnd = new Random();
            var visked = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                visked.Add(rnd.Next(1, 7)); // 1..6
            }

            Console.WriteLine("Viske tulemused: " + string.Join(" ", visked));
            int kuusCount = 0;
            foreach (var v in visked)
            {
                if (v == 6) kuusCount++;
            }
            Console.WriteLine($"Mitu korda visati 6? {kuusCount}");
        }

        public static (double Area, double Circumference) ArvutaRing(double raadius)
        {
            double pindala = Math.PI * raadius * raadius;
            double umbermoot = 2 * Math.PI * raadius;
            return (pindala, umbermoot);
        }
    }
}
