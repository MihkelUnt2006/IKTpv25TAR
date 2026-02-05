using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class Osa2_funktisoonid
    {
        public static string Juku(string nimi= "Juku")
        {
            string otsus = "";
            string vastus= "";
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
                otsus = "Ma olen hõivatud";
            }
            vastus=$"Tere {nimi}, {otsus}";
            return vastus;
        }
       

    }
}
