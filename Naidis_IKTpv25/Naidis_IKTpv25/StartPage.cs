using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid, Alamfunktsioonid/meetodid");
            string tekst = "Tere tulemast C#-i maailma! ";
            Console.WriteLine($"oli loodud muutuja tekst, mis võrdun: {tekst}");
            Console.WriteLine("\"oli loodud muutuja tekst, mis võrdun: {0}", tekst);
            Console.Write("Mis on sinu nimi");
            string nimi = Console.ReadLine();
            Console.Write("Kui vana sa oled?: ");
            try
            {
               int vanus= int.Parse(Console.ReadLine());
               Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
            try
            {
               Console.Write("Arv 1: ");
               float a = float.Parse( Console.ReadLine());
               Console.Write("arv 2: ");
               float b = float.Parse(Console.ReadLine());
                float vastus = Naidis_funktisoonid.Summa(a, b);
                Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
           


        }

    }
}
