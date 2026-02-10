using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace KodunetööMihkelUnt11._02
{
    public class KaheInimeseNimi
    {
       public static void Nimi()
       {
            Console.WriteLine("Sisesta  esimene nimi ");
            string nimi1 = Console.ReadLine();

            Console.WriteLine("Sisesta teine nimi ");
            string nimi2 = Console.ReadLine();

            if (nimi1 !="" && nimi2 !="")
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
