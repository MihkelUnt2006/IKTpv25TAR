using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage_Osa4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("4. osa funktsioonid");
            string valik = Console.ReadLine();
            string fail = "";
            List<string> list = new List<string>();

            switch (valik)
            {
                case "1": Osa4_funktsioonid.tekstisisestamine(); break;
                case "2": Osa4_funktsioonid.Tekstilugemine(); break;
                case "3":
                    Console.WriteLine("failinimi: ");
                    string fail = Console.ReadLine();
                    Osa4_funktsioonid.Ridade_lugemine(fail);
                    break;

                case "4":
                    Console.WriteLine("failinimi: ");
                    fail = Console.ReadLine();
                    list = Osa4_funktsioonid.Ridade_lugemine_listiks(fail);
                    break;
                default: Console.WriteLine("sisesta kehtiv number: "); break;
            }
        }

    }
}
