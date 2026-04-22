using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMihkel
{
    // Õpetaja pärib klassist Isik (koolon tähistab pärimist)
    public class Õpetaja : Isik, ITööline, IHindaja
    {
        public string Aine { get; set; }

        public double Tunnitasu { get; set; }

        public int Tunnidkuus { get; set; }

        public Õpetaja() : base()
        {

        }

        public Õpetaja(string nimi, string aine, double tunnitasu)
        {
            Nimi = nimi;
            Aine = aine;
            Tunnitasu = tunnitasu;
            
        }

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.palk;

        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        // override kirjutab abstraktse meetodi üle
        public override string Kirjelda()
        {
            return $"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.";
        }
        public virtual double ArvutaPalk()
        {
            return Tunnitasu * Tunnidkuus;
        }
        public void Hinda(string hinne)
        {
            Console.WriteLine($"Õpetaja paneb: {hinne}");
        }
    }

}
