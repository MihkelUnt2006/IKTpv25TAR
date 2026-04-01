using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage_Osa4
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("4. Osa Funktsioonid");
                Console.WriteLine("1 tekstisisestamine");
                Console.WriteLine("2 tekstilugemine");
                Console.WriteLine("3 Ridade lugemine");
                Console.WriteLine("4 Ridade lugemine listiks");
                Console.WriteLine("5 listi muutmine ");
                Console.WriteLine("6 otsimine listis");
                
                string valik = Console.ReadLine();
                string file = "";
                List<string> list = new List<string>();
                switch (valik)
                {
                    case "1": Osa4_funktsioonid.tekstisisestamine(); break;
                    case "2": Osa4_funktsioonid.Tekstilugemine(); break;

                    case "3":
                        Console.Write("failinimi: ");
                        file = Console.ReadLine();
                        Osa4_funktsioonid.Ridade_lugemine(file);


                        break;
                    case "4":
                        Console.Write("failinimi: ");
                        file = Console.ReadLine();
                        list = Osa4_funktsioonid.Ridade_lugemine_listiks(file);


                        break;
                    case "5":
                        Osa4_funktsioonid.listi_muutmine(file);break;
                    case "6":
                        Osa4_funktsioonid.Otsing(file); break;
                    default: Console.Write("sisesta kehtiv number: "); break;
                }
            }

        }
    }
}