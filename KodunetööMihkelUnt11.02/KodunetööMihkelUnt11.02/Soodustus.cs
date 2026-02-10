using System;
using System.Collections.Generic;
using System.Text;

namespace KodunetööMihkelUnt11._02
{
    public class Soodustus
    {
        public static void soodustus()
        {
            Console.WriteLine("Sisesta 30% soodushind");
            double soodushind = double.Parse(Console.ReadLine());

            double algneHind = soodushind * 100 / 30; 
            Console.WriteLine("Alghind oli umbes " + algneHind.ToString("F2") + "euro.");
        }
    }
}
