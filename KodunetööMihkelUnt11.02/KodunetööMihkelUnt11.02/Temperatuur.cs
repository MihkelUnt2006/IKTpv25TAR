using System;
using System.Collections.Generic;
using System.Text;

namespace KodunetööMihkelUnt11._02
{
    public class Temperatuur
    {
        public static void temperatuur()
        {
            Console.Write("Sisesta temperatuur (°C): ");
            double temp = double.Parse(Console.ReadLine());

            if (temp > 18)
                Console.WriteLine("Temperatuur on üle 18 kraadi.");
            else
                Console.WriteLine("Temperatuur ei ole üle 18 kraadi.");
        }
    }
}
