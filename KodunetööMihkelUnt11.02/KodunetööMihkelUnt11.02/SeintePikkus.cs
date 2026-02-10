using System;
using System.Collections.Generic;
using System.Text;

namespace KodunetööMihkelUnt11._02
{
    public class SeintePikkus
    {
        public static void seintePikkus()
        {
            Console.Write("Sisesta toa esimese seina pikkus (m): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta toa teise seina pikkus (m): ");
            double b = double.Parse(Console.ReadLine());

            double pindala = a * b;
            Console.WriteLine("Põranda pindala on " + pindala + " m2.");

            Console.Write("Kas soovid remonti teha? (jah/ei): ");
            string soov = Console.ReadLine();

            if (soov == "jah")
            {
                Console.Write("Sisesta ruutmeetri hind (€/m2): ");
                double ruutmeetriHind = double.Parse(Console.ReadLine());

                double hind = pindala * ruutmeetriHind;
                Console.WriteLine("Põranda vahetamise hind on " + hind + " euro.");
            }
            else
            {
                Console.WriteLine("Remonti ei arvutata.");
            }
        }
    }
}
