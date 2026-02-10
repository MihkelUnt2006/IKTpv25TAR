using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace KodunetööMihkelUnt11._02
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali Meetod ");
            Console.WriteLine("Sisesta Number ");
            Console.WriteLine("1. Kahe Inimese Nimi ");
            Console.WriteLine("2. Seinte pikkus ");
            Console.WriteLine("3. Soodustus ");
            Console.WriteLine("4. Temperatuur ");
            Console.WriteLine("5. Inim Pikkus ");
            Console.WriteLine("6. Inim Pikkus ja Sugu");
            Console.WriteLine("7. Poes Ostetud Asjad ");

            string valik = Console.ReadLine();
            switch (valik)
            {
                case "1":
                    KaheInimeseNimi.Nimi();
                    break;
                case "2":
                    SeintePikkus.seintePikkus();
                    break;
                case "3":
                    Soodustus.soodustus();
                    break;
                case "4":
                    Temperatuur.temperatuur();
                    break;
                case "5":
                    InimPikkus.inimPikkus();
                    break;
                case "6":
                    InimPikkusJaSugu.inimPikkusJaSugu();
                    break;
                case "7":
                    PoesOstetudAsjad.poesOstetudAsjad();
                    break;
                default:
                    Console.WriteLine("Valik on vale, palun vali uuesti");
                    break;
            }
        }
        

    }
}
