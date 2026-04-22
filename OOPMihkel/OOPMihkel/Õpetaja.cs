using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMihkel
{
    // Õpetaja pärib klassist Isik (koolon tähistab pärimist)
    public class Õpetaja : Isik, ITööline
    {
        public string Aine { get; set; }

        public double Tunnitasu { get; set; }

        public int Tunnidkuus { get; set; }

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.palk;

        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        // override kirjutab abstraktse meetodi üle
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
        public double ArvutaPalk()
        {
            return Tunnitasu * Tunnidkuus;
        }
    }

}
