using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class Osa2_funktisoonid
    {
        public static string Juku(string nimi = "Juku")
        {
            string otsus = "";
            string vastus = "";
            int vanus = 0;
            string pilet = "";
            Console.WriteLine("Mis on sinu nimi ");
            if (nimi.ToLower() == "juku")
            {
                Console.WriteLine("Kui vana sa oled?: ");
                try
                {
                    vanus = int.Parse(Console.ReadLine());
                    if (vanus > 0 && vanus < 100)
                    {
                        if (vanus < 6)
                        {
                            pilet = "Sulle on kinopilet tasuta";
                        }
                        else if (vanus >= 6 && vanus < 14)
                        {
                            pilet = "sulle on lastepilet";
                        }
                        else if (vanus >= 14 && vanus < 65)
                        {
                            pilet = "sulle on täispilet";
                        }
                        else if (vanus < 65)
                        {
                            pilet = "sulle on kinopilet sooduspilet!";
                        }

                    }
                    else
                    {
                        Console.WriteLine("Vanus peab olema >0 ja < kui 100!");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                otsus = $"Lähme Kinno! {pilet}";


            }
            else
            {
                otsus = $"Ma olen hõivatud";
            }
            vastus = $"Tere {nimi}, {otsus}";
            return vastus;
        }
        static List<string> pinginaabridList = new List<string>();

        public static void Pinginaabrid()
        {
            Console.WriteLine("Sisesta esimene nimi ");
            string nimi1 = Console.ReadLine();
    
            Console.WriteLine("Sisesta teine nimi ");
            string nimi2 = Console.ReadLine();
    
            if (nimi1 != "" && nimi2 != "")
            {
                Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid.");
    
                // Lisame paari listi
                pinginaabridList.Add($"{nimi1} ja {nimi2}");
            }
            else
            {
                Console.WriteLine("Palun sisesta kaks nime");
            }
        }
        public static void NäitaKõikiPinginaabreid()
        {
            Console.WriteLine("Kõik pinginaabrid:");
            foreach (var paar in pinginaabridList)
            {
                Console.WriteLine(paar);
            }
        }


        
        public static void RemondiKalk()
        {
            Console.Write("Sisesta toa esimese seina pikkus (m): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta toa teise seina pikkus (m): ");
            double b = double.Parse(Console.ReadLine());

            double pindala = a * b;
            Console.WriteLine("Põranda pindala on " + pindala + " m2.");

            Console.Write("Kas soovid remonti teha? (jah/ei): ");
            string soov = Console.ReadLine();

            if (soov == "jah")
            {
                Console.Write("Sisesta ruutmeetri hind (€/m2): ");
                double ruutmeetriHind = double.Parse(Console.ReadLine());

                double hind = pindala * ruutmeetriHind;
                Console.WriteLine("Põranda vahetamise hind on " + hind + " euro.");
            }
            else
            {
                Console.WriteLine("Remonti ei arvutata.");
            }
        }
        public static void soodustus()
        {
            Console.WriteLine("Sisesta 30% soodushind");
            double soodushind = double.Parse(Console.ReadLine());

            double algneHind = soodushind * 100 / 30;
            Console.WriteLine("Alghind oli umbes " + algneHind.ToString("F2") + "euro.");
        }
        public static void temperatuur()
        {
            Console.Write("Sisesta temperatuur (°C): ");
            double temp = double.Parse(Console.ReadLine());

            if (temp > 18)
                Console.WriteLine("Temperatuur on üle 18 kraadi.");
            else
                Console.WriteLine("Temperatuur ei ole üle 18 kraadi.");
        }
        public static void inimPikkus()
        {
            Console.WriteLine("Sisesta pikkus ");
            int pikkus = int.Parse(Console.ReadLine());

            if (pikkus < 163)
            {
                Console.WriteLine("Sa oled lühikest pikkust ");
            }
            else if (pikkus < 185)
            {
                Console.WriteLine(" Sa oled keskmist pikkust ");
            }
            else
            {
                Console.WriteLine("Sa oled pikk");
            }
        }
        public static void inimPikkusJaSugu()
        {
            Console.Write("Sisesta sugu (m/n): ");
            string sugu = Console.ReadLine().Trim().ToLower();

            Console.Write("Sisesta pikkus (cm): ");
            int pikkus = int.Parse(Console.ReadLine());

            if (sugu == "m")
            {
                if (pikkus < 170) Console.WriteLine("Sa oled lühikest pikkust.");
                else if (pikkus <= 190) Console.WriteLine("Sa oled keskmist pikkust.");
                else Console.WriteLine("Sa oled pikk.");
            }
            else if (sugu == "n")
            {
                if (pikkus < 160) Console.WriteLine("Sa oled lühikest pikkust.");
                else if (pikkus <= 180) Console.WriteLine("Sa oled keskmist pikkust.");
                else Console.WriteLine("Sa oled pikk.");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public static void poesOstetudAsjad()
        {
            double hindPiim = 1.20;
            double hindSai = 0.90;
            double hindLeib = 1.50;

            double summa = 0;
            string ostud = "";

            Console.Write("Kas soovid osta piima? (jah/ei): ");
            string piim = Console.ReadLine();
            if (piim == "jah")
            {
                summa += hindPiim;
                ostud += "piim ";
            }

            Console.Write("Kas soovid osta saia? (jah/ei): ");
            string sai = Console.ReadLine();
            if (sai == "jah")
            {
                summa += hindSai;
                ostud += "sai ";
            }

            Console.Write("Kas soovid osta leiba? (jah/ei): ");
            string leib = Console.ReadLine();
            if (leib == "jah")
            {
                summa += hindLeib;
                ostud += "leib ";
            }

            if (ostud == "")
                Console.WriteLine("Sa ei ostnud midagi.");
            else
                Console.WriteLine("Ostetud: " + ostud + "Kokku: " + summa + " euro.");
        }
    }
}
