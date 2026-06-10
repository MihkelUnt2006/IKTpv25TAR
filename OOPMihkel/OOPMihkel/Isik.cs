using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMihkel
{
    public abstract class Isik
    {
        
        
        public static int InimesteKoguarv = 0;

        public Isik(string nimi)
        {
            Nimi = nimi;

            
            
            InimesteKoguarv++;
        }

        protected Isik()
        {
            InimesteKoguarv++;
        }



       
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
        
        public abstract string Kirjelda();



        
        private int sünniaasta;

         
            public string Nimi { get; set; }

            
            public int Sünniaasta
            {
                get { return sünniaasta; }
                set
                {
                    if (value > 1900 && value <= DateTime.Now.Year)
                        sünniaasta = value;
                    else
                        throw new ArgumentException($"Vigane aasta: {value}! Aasta peab olema vahemikus 1900-{DateTime.Now.Year}");
                }
            }



      
        public int Vanus => sünniaasta == 0 ? 0 : DateTime.Now.Year - sünniaasta;
        
    }
}
