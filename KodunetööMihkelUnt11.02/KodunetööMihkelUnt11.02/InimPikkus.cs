using System;
using System.Collections.Generic;
using System.Text;

namespace KodunetööMihkelUnt11._02
{
    internal class InimPikkus
    {
       public static void inimPikkus()
        {
            Console.WriteLine("Sisesta pikkus ");
            int pikkus = int.Parse(Console.ReadLine());

            if (pikkus < 163)
            {
                Console.WriteLine("Sa oled lühikest pikkust ");
            }
            else if (pikkus < 185) 
            {
                Console.WriteLine(" Sa oled keskmist pikkust ");
            }
            else
            {
                Console.WriteLine("Sa oled pikk");
            }

        }
    }
}
