using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Buss : ISõiduk
    {
        public double KutuseKulu100Km { get; set; }
        public double Kilomeetrid { get; set; }
        public double KutuseHind { get; set; }
        public int Reisijad { get; set; }

        public Buss(double kutuseKulu100Km, double kilomeetrid, double kutuseHind, int reisijad)
        {
            KutuseKulu100Km = kutuseKulu100Km;
            Kilomeetrid = kilomeetrid;
            KutuseHind = kutuseHind;
            Reisijad = reisijad;
        }

        // Arvutab ühe reisija kulu eurodes
        public double ArvutaKulu()
        {
            double liitrid = (KutuseKulu100Km / 100) * Kilomeetrid;
            double koguHind = liitrid * KutuseHind;

            return koguHind / Reisijad;
        }

        public double ArvutaVahemaa()
        {
            return Kilomeetrid;
        }

        public override string ToString()
        {
            return $"Buss | Kulu reisija kohta: {ArvutaKulu():F2} € | Vahemaa: {Kilomeetrid} km";
        }
    }
}

