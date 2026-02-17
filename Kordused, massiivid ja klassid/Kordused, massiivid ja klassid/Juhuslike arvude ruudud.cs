using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class Juhuslike_arvude_ruudud
    {
       public static int[] JuhuslikeArvudeRuudud(int min, int max)
        {
            Random rnd = new Random();
            int n = rnd.Next(min, max + 1);
            int m = rnd.Next(min, max + 1);
            int alg = Math.Min(n, m);
            int lopp = Math.Max(n, m);
            int[] tulemused = new int[lopp - alg + 1];

            for (int i = 0; i < tulemused.Length; i++)
            {
                  tulemused[i] = (alg + i) * (alg + i);
            }
            Console.WriteLine($"Vahemik: {alg} kuni {lopp}");
            return tulemused;
        }

        public static void Run()
        {
            var results = JuhuslikeArvudeRuudud(1, 10);
            Console.WriteLine("Ruudud:");
            foreach (var r in results)
                Console.WriteLine(r);
        }
    }
}
