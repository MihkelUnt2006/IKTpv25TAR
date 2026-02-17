using System;
using System.Collections.Generic;
using System.Text;

namespace Kordused__massiivid_ja_klassid
{
    public class MainPaige
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine(" Vali ülesanne: ");
                Console.WriteLine("1  - Juhuslike arvude ruudud");
                Console.WriteLine("2  - Viie arvu analüüs");
                Console.WriteLine("3  - Nimed ja vanused");
                Console.WriteLine("4  - Osta elevant ära");
                Console.WriteLine("5  - Arvamise mäng");
                Console.WriteLine("6  - Suurim neliarvuline arv");
                Console.WriteLine("7  - Korrutustabel");
                Console.WriteLine("8  - Õpilastega mängimine");
                Console.WriteLine("9  - Arvude ruudud (massiiv)");
                Console.WriteLine("10 - Positiivsed ja negatiivsed");
                Console.WriteLine("11 - Keskmisest suuremad");
                Console.WriteLine("12 - Suurima arvu otsing");
                Console.WriteLine("13 - Paaris ja paaritud");
                
                string valik = Console.ReadLine();
                switch (valik)
                {
                    case "1":
                        Juhuslike_arvude_ruudud.Run();
                        break;
                    case "2":
                        five_arv_analuus.Run();
                        break;
                    case "3":
                        InimesteTootlus.Run();
                        break;
                    case "4":
                        arvamisemang.Run();
                        break;
                    case "5":
                        arvam_isemang.Run();
                        break;
                    case "6":
                        SuurimNeljakohaneArv.Run();
                        break;
                    case "7":
                        Korrutustabel.Run();
                        break;
                    case "8":
                        Õpilastega_mängimine.Run();
                        break;
                    case "9":
                        ArvudeRuudud.Run();
                        break;
                    case "10":
                        PositiivsedJaNegatiivsed.Run();
                        break;
                    case "11":
                        KeskmisestSuuramad.Run();
                        break;
                    case "12":
                        SuuremaOtsing.Run();
                        break;
                    case "13":
                        Paarisarvud.Run();
                        break;
                    default:
                        Console.WriteLine("Vigane valik, proovi uuesti.");
                        break;
                }
            }
        }
    }
}
