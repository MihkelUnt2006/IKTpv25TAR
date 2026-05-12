using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMihkel
{
    // Õpilane pärib klassist Isik
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public double KeskmineHinne { get; set; }
        public int Puudumised { get; set; } = 0;

        public bool KasOnSotsTõend { get; set; } = false;
        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Toetus;
        public Õppevorm Staatus { get; set; } // Kasutame enumi andmetüübina

        public Õpilane() : base()
        {
            
        }
        public Õpilane(string nimi, string kool, int klass) : base(nimi)
        {
            Nimi = nimi;
            Kool = kool;
            Klass = klass;
        }





        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }
        public override string Kirjelda()
        {
            return $"{Nimi} õpib {Klass}. klassis. Vorm: {Staatus}";
        }
        public double ArvutaPalk()
        {
            //if (KeskmineHinne < 3.8 && Puudumised > 30)
            //{
            //    return 0;
            //}
            //else if (KasOnSotsTõend =)
            //{
            //    return 60 + 120;
            //}
            //else
            //{
            //    return 60;
            //}
            double põhitoetus = 0;
            double eritoetus = 0;
            if (KeskmineHinne >= 3.8 && Puudumised <= 30)
            {
                põhitoetus += 60;

            }
            if (KasOnSotsTõend)
            {
                eritoetus += 120;
            }
            return põhitoetus + eritoetus;
        }
       
    }
}
