using System;
using System.Collections.Generic;
using System.Text;

namespace Soidukite_liidese_rakendamine
{
    public class Mootorratas : ISõiduk
    {
        public double KutuseKulu100Km { get; set; }
        public double Kilomeetrid { get; set; }

        public Mootorratas(double kutuseKulu100Km, double kilomeetrid)
        {
            KutuseKulu100Km = kutuseKulu100Km;
            Kilomeetrid = kilomeetrid;
        }

        // Arvutab mootorratta kütusekulu
        public double ArvutaKulu()
        {
            return (KutuseKulu100Km / 100) * Kilomeetrid;
        }

        public double ArvutaVahemaa()
        {
            return Kilomeetrid;
        }

        public override string ToString()
        {
            return $"Mootorratas | Kulu: {ArvutaKulu():F2} l | Vahemaa: {Kilomeetrid} km";
        }
    }
}
