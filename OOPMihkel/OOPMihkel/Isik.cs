using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMihkel
{
    public class Isik
    {
        // Omadused ehk väljad
        //public string Nimi;
        //public int Vanus;

        // Tegevus ehk meetod 
        public void Tervita()
        {
            if(string.IsNullOrEmpty(Nimi) || sünniaasta == 0)
            {
                Console.WriteLine("Tere! Ma ei tea veel oma nime ega sünniaastat");
            }
            else
            {
                Console.WriteLine($"Tere! Mina olen {Nimi}, ma olen {Vanus} ja ma olen sündinud aastal {Sünniaasta}");
            }
                
        }



        // Privaatne väli - otse ligi ei saa
        private int sünniaasta;

            // Avalik omadus (Property) automaatse get/set logikaga
            public string Nimi { get; set; }

            // Kontrollitud omadus
            public int Sünniaasta
            {
                get { return sünniaasta; }
                set
                {
                    if (value > 1900 && value <= DateTime.Now.Year)
                        sünniaasta = value;
                    else
                        Console.WriteLine("Vigane sünniaasta!");

                    
                }
            }



        // Arvutatud omadus (ainult lugemiseks / getter)
        public int Vanus => sünniaasta == 0 ? 0 : DateTime.Now.Year - sünniaasta;
        
    }
}
