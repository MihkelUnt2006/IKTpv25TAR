using System;
using System.Collections.Generic;
using System.Text;

namespace KodunetööMihkelUnt11._02
{
    public class PoesOstetudAsjad
    {
        public static void poesOstetudAsjad()
        {
            double hindPiim = 1.20;
            double hindSai = 0.90;
            double hindLeib = 1.50;

            double summa = 0;
            string ostud = "";

            Console.Write("Kas soovid osta piima? (jah/ei): ");
            string piim = Console.ReadLine();
            if (piim == "jah")
            {
                summa += hindPiim;
                ostud += "piim ";
            }

            Console.Write("Kas soovid osta saia? (jah/ei): ");
            string sai = Console.ReadLine();
            if (sai == "jah")
            {
                summa += hindSai;
                ostud += "sai ";
            }

            Console.Write("Kas soovid osta leiba? (jah/ei): ");
            string leib = Console.ReadLine();
            if (leib == "jah")
            {
                summa += hindLeib;
                ostud += "leib ";
            }

            if (ostud == "")
                Console.WriteLine("Sa ei ostnud midagi.");
            else
                Console.WriteLine("Ostetud: " + ostud + "Kokku: " + summa + " €.");
        }
    }
}
