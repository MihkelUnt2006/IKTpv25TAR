using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class five_arv_analuus
    {
        public static Tuple<double, double, double> ViieArvuAnalüüs(double[] arvud)
        {
            double summa = 0;
            double korrutis = 1;

            foreach (double arv in arvud)
            {
                summa += arv;
                korrutis *= arv;
            }

            double keskmine = summa / arvud.Length;

            return new Tuple<double, double, double>(summa, keskmine, korrutis);
        }

        public static void Run()
        {
            var tup = ViieArvuAnalüüs(new double[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"Summa: {tup.Item1}, Keskmine: {tup.Item2}, Korrutis: {tup.Item3}");
        }

    }
}
