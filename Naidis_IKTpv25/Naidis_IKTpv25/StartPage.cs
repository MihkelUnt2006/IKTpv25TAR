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
            //bool working = true;
            //while (working)
            //{
            //    Console.WriteLine(" Peamine menüü ");
            //    Console.WriteLine("1 Osa 1 funktsioonid");
            //    Console.WriteLine("2 Osa 2 funktsioonid");
            //    Console.WriteLine("3 Osa 3 funktsioonid");
            //    Console.WriteLine("4 exit");
            //    Console.Write("Vali osa");
            //    int osa = Convert.ToInt32(Console.ReadLine());
            //}
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
            
            Console.WriteLine("1, 2, 3 Osa Funktsioonid");
            Console.WriteLine("1. Juku");
            Console.WriteLine("2. Pinginaabrid");
            Console.WriteLine("3. Pindala");
            Console.WriteLine("4. Soodus");
            Console.WriteLine("5. Temperatuur");
            Console.WriteLine("6. Pikkus");
            Console.WriteLine("7. Pood");
            Console.WriteLine("8. MuudaElement");
            Console.WriteLine("9. Täida_massiiv");
            Console.WriteLine("10. foreachFunktsioon");
            Console.WriteLine("11. GenereeriRuudud");
            Console.WriteLine("12. Täida_Doublemassiiv");
            Console.WriteLine("13. ostaElevantAra");
            Console.WriteLine("14. arvumang");
            Console.WriteLine("15. SuurimNeliarv");
            Console.WriteLine("16. GenereeriKorrutustabel");
            Console.WriteLine("17. arvudRuudud");
            Console.WriteLine("18. Positiivsed_ja_negatiivsed");
            Console.WriteLine("19. Rohkem kui keskmine");
            Console.WriteLine("20. suurimJaIndeks");
            Console.WriteLine("21. Statistika Inimesed");
            Console.WriteLine("22. ÕpilastegaMängimine");
            Console.WriteLine("23. binaariOtsing");
            Console.WriteLine("24. PaariPaaritud");
            Console.WriteLine("25. Näita pinginaabreid");
            Console.WriteLine("26. Kontrolli pinginaabreid");
            


            string valik = Console.ReadLine();
                
                if (valik == "1")
                {
                    Osa2_funktisoonid.Juku();
                }
                else if (valik == "2")
                {
                    Osa2_funktisoonid.Pinginaabrid();
                }
                else if (valik == "3")
                {
                    Osa2_funktisoonid.RemondiKalk();
                }
                else if (valik == "4")
                {
                    Osa2_funktisoonid.soodustus();
                }
                else if (valik == "5")
                {
                    Osa2_funktisoonid.temperatuur();
                }
                else if (valik == "6")
                {
                    Osa2_funktisoonid.inimPikkus();
                }
                else if (valik == "7")
                {
                    Osa2_funktisoonid.inimPikkusJaSugu();
                }
                else if (valik == "8")
                {
                    Osa2_funktisoonid.poesOstetudAsjad();
                }
                else if (valik == "9")
                {
                    Osa3_funktsioonid.JuhuslkiudRuudud();
                }
                else if (valik == "10")
                {
                    Osa3_funktsioonid.arvuAnaluus(new double[] { 1, 2, 3, 4, 5 });
                }
                else if (valik == "11")
                {
                    Osa3_funktsioonid.ostaElevantAra();
                }
                
                else if (valik == "12")
                {
                    Osa3_funktsioonid.arvumang();
                }
                else if (valik == "13")
                {
                    Osa3_funktsioonid.SuurimNeliarv();
                }
                else if (valik == "14")
                {
                    Osa3_funktsioonid.Korrutustabel(10, 10);
                }
                else if (valik == "15")
                {
                    Osa3_funktsioonid.ArvudeRuudud();
                }
                else if (valik == "16")
                {
                    Osa3_funktsioonid.PosJaNeg();
                }
                else if (valik == "17")
                {
                    Osa3_funktsioonid.KeskSuuremad();
                }
                else if (valik == "18")
                {
                    Osa3_funktsioonid.KoigeSuuremaOtsing();
                }
                else if (valik == "19")
                {
                    Osa3_funktsioonid.PaarisjaPaaritu();
                }
                else if (valik == "20")
                {
                    Osa2_funktisoonid.NäitaKõikiPinginaabreid();
                }
                else
                {
                    Console.WriteLine("Viga! Palun vali uuesti");
                }
                  

                

                Random rnd = new Random();
                int juhuslik_arv = rnd.Next(-5, 25);

                Console.WriteLine(Naidis_funktisoonid.Kuu_nimetus(juhuslik_arv));
                juhuslik_arv = rnd.Next(-5, 25);

                tekst = Naidis_funktisoonid.Kuu_nimetus(juhuslik_arv);
                Console.WriteLine(tekst);

                Console.Write(Osa2_funktisoonid.Juku());
                Console.Write(Osa2_funktisoonid.Juku(nimi));
                Console.Write(Osa2_funktisoonid.Juku("Python"));

                
                


            
        }
    }
}
