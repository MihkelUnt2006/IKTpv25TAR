using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class Paarisarvud
    {
        public static void Run()
        {
            Random r = new Random();
            List<int> arvud = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                arvud.Add(r.Next(1, 101));
            }
            int paarisSumma = 0;
            foreach (int a in arvud)
            {
                if (a % 2 == 0)
                    paarisSumma = paarisSumma + a;
            }
            int paarituSumma = 0;
            int paarituKogus = 0;

            for (int i = 0; i < arvud.Count; i++)
            {
                if (arvud[i] % 2 != 0)
                {
                    paarituSumma = paarituSumma + arvud[i];
                    paarituKogus = paarituKogus + 1;
                }
            }

            double paarituKeskmine = 0;
            if (paarituKogus != 0)
                paarituKeskmine = (double)paarituSumma / paarituKogus;
            int nr = 0;
            int ule50 = 0;

            while (nr < arvud.Count)
            {
                if (arvud[nr] > 50)
                    ule50 = ule50 + 1;

                nr = nr + 1;
            }

            Console.WriteLine("Paarisarvude summa: " + paarisSumma);
            Console.WriteLine("Paaritute keskmine: " + paarituKeskmine);
            Console.WriteLine(">50 arvude kogus: " + ule50);
        }
    }
}
