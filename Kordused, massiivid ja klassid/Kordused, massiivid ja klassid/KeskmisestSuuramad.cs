using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class KeskmisestSuuramad
    {
        public static void Run()
        {
            Random r = new Random();
            int[] arvud = new int[15];

            int summa = 0;
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = r.Next(1, 101);
                summa = summa + arvud[i];
            }

            double keskmine = (double)summa / arvud.Length;

            Console.WriteLine("Keskmine: " + keskmine);
            Console.WriteLine("\nKeskmisest suuremad:");
            foreach (int a in arvud)
            {
                if (a > keskmine)
                    Console.WriteLine(a);
            }
            Console.WriteLine("\nDo-while kuni arv < 10:");
            int nr = 0;
            do
            {
                Console.WriteLine(arvud[nr]);
                if (arvud[nr] < 10)
                    break;

                nr = nr + 1;

            } while (nr < arvud.Length);

        }
    }
}