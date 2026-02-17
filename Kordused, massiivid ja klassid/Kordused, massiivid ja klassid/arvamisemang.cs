using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class arvam_isemang
    {
        public static void arvutamisemang()
        {
            Random rnd = new Random();
            int arv = rnd.Next(1, 101);

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Sisesta pakkumine: ");
                int pakkumine = int.Parse(Console.ReadLine());

                if (pakkumine == arv)
                {
                    Console.WriteLine("Õige!");
                    return;
                }
                else if (pakkumine > arv)
                    Console.WriteLine("Liiga suur");
                else
                    Console.WriteLine("Liiga väike");
            }

            Console.WriteLine($"Mäng läbi! Õige arv oli {arv}");
        }

        public static void Run()
        {
            arvutamisemang();
        }

    }
}
