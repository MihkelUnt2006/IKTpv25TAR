using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class arvamisemang
    {
        public static void KuniMärksõnani(string märksõna, string fraas)
        {
            List<string> sisestused = new List<string>();
            string sisend;

            do
            {
                Console.WriteLine(fraas);
                sisend = Console.ReadLine();
                sisestused.Add(sisend);

            } while (sisend != märksõna);

            Console.WriteLine("Kõik sisestused:");
            foreach (string s in sisestused)
                Console.WriteLine(s);
        }

        public static void Run()
        {
            KuniMärksõnani("STOP", "Sisesta sõna (STOP lõpetab):");
        }
    }
}
