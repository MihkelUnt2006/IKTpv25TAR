using System;
using System.Collections.Generic;
using System.Text;

namespace KodunetööMihkelUnt11._02
{
    public class InimPikkusJaSugu
    {
        public static void inimPikkusJaSugu()
        {
            Console.Write("Sisesta sugu (m/n): ");
            string sugu = Console.ReadLine().Trim().ToLower();

            Console.Write("Sisesta pikkus (cm): ");
            int pikkus = int.Parse(Console.ReadLine());

            if (sugu == "m")
            {
                if (pikkus < 170) Console.WriteLine("Sa oled lühikest pikkust.");
                else if (pikkus <= 190) Console.WriteLine("Sa oled keskmist pikkust.");
                else Console.WriteLine("Sa oled pikk.");
            }
            else if (sugu == "n")
            {
                if (pikkus < 160) Console.WriteLine("Sa oled lühikest pikkust.");
                else if (pikkus <= 180) Console.WriteLine("Sa oled keskmist pikkust.");
                else Console.WriteLine("Sa oled pikk.");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
