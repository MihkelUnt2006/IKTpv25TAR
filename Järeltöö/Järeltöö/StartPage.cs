using System;
using System.Collections.Generic;
using System.Text;

namespace Järeltöö
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            bool tootab = true;

            while (tootab)
            {
                Console.WriteLine("\n=== PEAMENÜÜ ===");
                Console.WriteLine("Vali tegevus:");
                Console.WriteLine("1 - Taksosõidu kalkulaator");
                Console.WriteLine("2 - Kellaaja eraldaja");
                Console.WriteLine("3 - Täringu statistika");
                Console.WriteLine("4 - Ringi arvutused");
                Console.WriteLine("0 - Välju");
                Console.Write("\nSinu valik: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Console.WriteLine("\n-- Taksosõidu kalkulaator --");
                        Alamfunktsioonid.TaksoKalkulaator();
                        break;

                    case "2":
                        Console.WriteLine("\n-- Kellaaja eraldaja --");
                        Console.Write("Sisesta kellaaeg (HH:MM:SS): ");
                        string kellaaeg = Console.ReadLine();
                        Alamfunktsioonid.HindaKellaaega(kellaaeg);
                        break;

                    case "3":
                        Console.WriteLine("\n-- Täringu statistika --");
                        Alamfunktsioonid.TaringuStatistika();
                        break;

                    case "4":
                        Console.WriteLine("\n-- Ringi arvutused --");
                        Console.Write("Sisesta ringi raadius: ");
                        double raadius = double.Parse(Console.ReadLine());
                        Tuple<double, double> ringiAndmed = Alamfunktsioonid.ArvutaRing(raadius);
                        Console.WriteLine($"Ringi pindala:    {Math.Round(ringiAndmed.Item1, 2)} cm²");
                        Console.WriteLine($"Ringi ümbermõõt:  {Math.Round(ringiAndmed.Item2, 2)} cm");
                        break;

                    case "0":
                        Console.WriteLine("Programm lõpetab töö. Head aega!");
                        tootab = false;
                        break;

                    default:
                        Console.WriteLine("Vigane valik! Palun vali 0-4.");
                        break;
                }
            }
        }
    }
}
