using System;
using System.Collections.Generic;
using System.Text;

namespace Järeltöö
{
    public class Alamfunktsioonid
    {
        
        public static void TaksoKalkulaator()
        {
            Console.Write("Sisesta sisseistumistasu (€): ");
            double sisseistumistasu = double.Parse(Console.ReadLine());

            Console.Write("Sisesta kilomeetri hind (€/km): ");
            double kmHind = double.Parse(Console.ReadLine());

            Console.Write("Sisesta läbitud kilomeetrid (km): ");
            double kilomeetrid = double.Parse(Console.ReadLine());

            double kogumaksumus = sisseistumistasu + (kmHind * kilomeetrid);

            Console.WriteLine($"\nTaksosõidu kogumaksumus: {kogumaksumus:F2} €");
        }

        
        public static void HindaKellaaega(string kellaaeg)
        {
            if (kellaaeg.Length != 8)
            {
                Console.WriteLine("Vigane kellaaja formaat!");
                return;
            }

            string tunnid = kellaaeg.Substring(0, 2);
            string minutid = kellaaeg.Substring(3, 2);
            string sekundid = kellaaeg.Substring(6, 2);

            Console.WriteLine($"Kell on täpselt {tunnid} tundi, {minutid} minutit ja {sekundid} sekundit.");
        }

        
        public static void TaringuStatistika()
        {
            Random rnd = new Random();
            List<int> tulemused = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int vise = rnd.Next(1, 7);
                tulemused.Add(vise);
            }

            Console.Write("Viske tulemused: ");
            for (int i = 0; i < tulemused.Count; i++)
            {
                if (i < tulemused.Count - 1)
                    Console.Write(tulemused[i] + ", ");
                else
                    Console.Write(tulemused[i]);
            }
            Console.WriteLine();

            int kuuedArv = 0;
            foreach (int tulemus in tulemused)
            {
                if (tulemus == 6)
                    kuuedArv++;
            }

            Console.WriteLine($"Numbrit 6 visati: {kuuedArv} korda.");
        }

        
        public static Tuple<double, double> ArvutaRing(double raadius)
        {
            double pindala = Math.PI * raadius * raadius;
            double umbermoot = 2 * Math.PI * raadius;
            return new Tuple<double, double>(pindala, umbermoot);
        }
    }
}
