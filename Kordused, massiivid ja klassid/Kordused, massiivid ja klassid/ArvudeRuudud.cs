using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class ArvudeRuudud
    {
        public static void Run()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };
            Console.WriteLine("Ruudud (for):");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine(arvud[i] + " -> " + (arvud[i] * arvud[i]));
            }
            Console.WriteLine("\nKahekordsed (foreach):");
            foreach (int a in arvud)
            {
                Console.WriteLine(a + " -> " + (a * 2));
            }
            Console.WriteLine("\nJagub 3-ga (while loendus):");
            int nr = 0;
            int loendur = 0;

            while (nr < arvud.Length)
            {
                if (arvud[nr] % 3 == 0)
                {
                    loendur = loendur + 1;
                }
                nr = nr + 1;
            }

            Console.WriteLine("Kogus: " + loendur);
        }
    }
}