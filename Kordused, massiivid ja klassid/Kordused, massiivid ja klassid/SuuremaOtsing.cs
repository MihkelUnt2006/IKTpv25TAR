using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class SuuremaOtsing
    {
        public static void Run()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int max = numbrid[0];
            int maxIndeks = 0;

            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] > max)
                {
                    max = numbrid[i];
                    maxIndeks = i;
                }
            }

            Console.WriteLine("Suurim arv: " + max);
            Console.WriteLine("Indeks: " + maxIndeks);
        }
    }
}
