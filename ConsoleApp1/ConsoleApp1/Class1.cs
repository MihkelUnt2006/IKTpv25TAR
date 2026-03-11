using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class1
    {
        public static void Pinginaabrid()
        {
            Console.WriteLine("Sisesta esimene nimi ");
            string nimi1 = Console.ReadLine();

            Console.WriteLine("Sisesta teine nimi ");
            string nimi2 = Console.ReadLine();

            if (nimi1 != "" && nimi2 != "")
            {
                Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid.");
            }
            else
            {
                Console.WriteLine("Palun sisesta kaks nime");
            }
        }
    }
}