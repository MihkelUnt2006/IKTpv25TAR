using System;
using System.Globalization;

namespace Järeltöö_Mihkel
{
    internal class StartPage
    {
        static void Main()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("Vali tegevus:");
                Console.WriteLine("1 - Taksosõidu kalkulaator");
                Console.WriteLine("2 - Kellaaja eraldaja");
                Console.WriteLine("3 - Täringu statistika");
                Console.WriteLine("4 - Ringi arvutused");
                Console.WriteLine("0 - Välju");
                Console.Write("Valik: ");
                string? valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Alamfunktsioonid.TaksoKalkulaator();
                        break;
                    case "2":
                        Alamfunktsioonid.HindaKellaaega();
                        break;
                    case "3":
                        Alamfunktsioonid.TaringuStatistika();
                        break;
                    case "4":
                        Console.Write("Sisesta ringi raadius: ");
                        var rline = Console.ReadLine();
                        if (double.TryParse(rline?.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double r) && r >= 0)
                        {
                            var result = Alamfunktsioonid.ArvutaRing(r);
                            Console.WriteLine($"Pindala: {result.Area:F2}");
                            Console.WriteLine($"Ümbermõõt: {result.Circumference:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Vigane raadius!");
                        }
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Tundmatu valik, proovi uuesti.");
                        break;
                }
            }
        }
    }
}
