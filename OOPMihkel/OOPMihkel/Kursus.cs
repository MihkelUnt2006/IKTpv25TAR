using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMihkel
{
    
    public class Kursus
    {
        public string Nimi { get; set; }
        public Õpetaja VastutavÕpetaja { get; set; }

        public Kursus()
        {

        }

        public Kursus(string nimi, Õpetaja vastutavÕpetaja)
        {
            Nimi = nimi;
            VastutavÕpetaja = vastutavÕpetaja;
        }

        public void KuvaInfo()
        {
            if (VastutavÕpetaja != null)
            {
                Console.WriteLine($"Kursus: {Nimi} | Vastutav õpetaja: {VastutavÕpetaja.Nimi}");
            }
            else
            {
                Console.WriteLine($"Kursus: {Nimi} | Vastutavat õpetajat ei ole määratud");
            }
        }
    }
}
