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
            bool working = true;
            while (working)
            {
                Console.WriteLine(" Peamine menüü ");
                Console.WriteLine("1 Osa 1 funktsioonid");
                Console.WriteLine("2 Osa 2 funktsioonid");
                Console.WriteLine("3 Osa 3 funktsioonid");
                Console.WriteLine("4 exit");
                Console.Write("Vali osa");
                int osa = Convert.ToInt32(Console.ReadLine());
            }
            {

            }
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid, Alamfunktsioonid/meetodid");
            string tekst = "Tere tulemast C#-i maailma! ";
            Console.WriteLine($"oli loodud muutuja tekst, mis võrdun: {tekst}");
            Console.WriteLine("\"oli loodud muutuja tekst, mis võrdun: {0}", tekst);
            Console.Write("Mis on sinu nimi");
            string nimi = Console.ReadLine();
            //Console.Write("Kui vana sa oled?: ");
            //try
            //{
            //    int vanus = int.Parse(Console.ReadLine());
            //   Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);

            //}
            //try
            //{
            //    Console.Write("Arv 1: ");
            //    float a = float.Parse(Console.ReadLine());
            //    Console.Write("arv 2: ");
            //    float b = float.Parse(Console.ReadLine());
            //    float vastus = Naidis_funktisoonid.Summa(a, b);
            //    Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e);
            //}

           


            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);

            Console.WriteLine(Naidis_funktisoonid.Kuu_nimetus(juhuslik_arv));
            juhuslik_arv = rnd.Next(-5, 25);

            tekst = Naidis_funktisoonid.Kuu_nimetus(juhuslik_arv);
            Console.WriteLine(tekst);

            Console.Write(Osa2_funktisoonid.Juku());
            Console.Write(Osa2_funktisoonid.Juku(nimi));
            Console.Write(Osa2_funktisoonid.Juku("Python"));

            Osa2_funktisoonid.Pinginaabrid();

            Osa2_funktisoonid.RemondiKalk();

            Osa2_funktisoonid.soodustus();

            Osa2_funktisoonid.temperatuur();

            Osa2_funktisoonid.inimPikkus();

            Osa2_funktisoonid.inimPikkusJaSugu();

            Osa2_funktisoonid.poesOstetudAsjad();

            Osa3_funktsioonid.JuhuslkiudRuudud();
            Osa3_funktsioonid.arvuAnaluus(new double[] { 1, 2, 3, 4, 5 });

            Osa3_funktsioonid.ostaElevantAra();

            Osa3_funktsioonid.arvumang();

            Osa3_funktsioonid.SuurimNeliarv();

            Osa3_funktsioonid.Korrutustabel(10, 10);

            Osa3_funktsioonid.Opilastegmangimine();

            Osa3_funktsioonid.ArvudeRuudud();

            Osa3_funktsioonid.PosJaNeg();

            Osa3_funktsioonid.KeskSuuremad();

            Osa3_funktsioonid.KoigeSuuremaOtsing();

            Osa3_funktsioonid.PaarisjaPaaritu();


        }

    }
}
