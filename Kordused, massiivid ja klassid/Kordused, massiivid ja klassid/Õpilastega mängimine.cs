using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class Õpilastega_mängimine
    {
        public static void Run()
        {
            string[] nimed = new string[10] { "Andres", "Mari", "Aadu", "Peeter", "Anna", "Liis", "Airi", "Jaan", "Anu", "Tiit" };
            nimed[2] = "Kati";
            nimed[5] = "Mati";
            Console.WriteLine("A-ga algavad tervitused (while):");
            int nr = 0;
            while (nr < nimed.Length)
            {
                if (nimed[nr].StartsWith("A"))
                {
                    Console.WriteLine("Tere, " + nimed[nr]);
                }
                nr = nr + 1;
            }
            Console.WriteLine("\nKõik nimed ja indeksid (for):");
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine(i + " : " + nimed[i]);
            }
            Console.WriteLine("\nNimed väikeste tähtedena (foreach):");
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi.ToLower());
            }
            Console.WriteLine("\nTervitab kuni 'Mati' (do-while):");
            int k = 0;
            do
            {
                Console.WriteLine("Tere, " + nimed[k]);
                if (nimed[k] == "Mati")
                {
                    break;
                }
                k = k + 1;
            } while (k < nimed.Length);
        }
    }
}