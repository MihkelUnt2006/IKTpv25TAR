using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class SuurimNeljakohaneArv
    {
        public static int SuurimNeljakohane(int[] arvud)
        {
            for (int i = 0; i < arvud.Length - 1; i++)
            {
                for (int j = i + 1; j < arvud.Length; j++)
                {
                    if (arvud[j] > arvud[i])
                    {
                        int temp = arvud[i];
                        arvud[i] = arvud[j];
                        arvud[j] = temp;
                    }
                }
            }

            int tulemus = arvud[0] * 1000 +
                          arvud[1] * 100 +
                          arvud[2] * 10 +
                          arvud[3];

            return tulemus;
        }

        public static void Run()
        {
            int val = SuurimNeljakohane(new int[] { 9, 8, 7, 6 });
            Console.WriteLine("Suurim neljakohaline arv: " + val);
        }
    }
}
