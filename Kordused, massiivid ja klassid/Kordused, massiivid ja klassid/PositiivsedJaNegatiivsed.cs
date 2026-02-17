using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class PositiivsedJaNegatiivsed
    {
        public static void Run()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int pos = 0;
            int neg = 0;
            int nul = 0;

            foreach (int a in arvud)
            {
                if (a > 0)
                    pos = pos + 1;
                else if (a < 0)
                    neg = neg + 1;
                else
                    nul = nul + 1;
            }

            Console.WriteLine("Positiivseid: " + pos);
            Console.WriteLine("Negatiivseid: " + neg);
            Console.WriteLine("Nulle: " + nul);
        }
    }
}

