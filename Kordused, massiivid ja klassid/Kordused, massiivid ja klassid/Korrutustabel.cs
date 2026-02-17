using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class Korrutustabel
    {
        public static void GenereeriKorrutustabel(int read, int veerud)
        {
            int[,] tabel = new int[read, veerud];

            for (int i = 0; i < read; i++)
            {
                for (int j = 0; j < veerud; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabel[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void Run()
        {
            GenereeriKorrutustabel(5, 5);
        }
}
}
