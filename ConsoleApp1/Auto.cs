using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Auto : ISõiduk
    {
        public double KutuseKulu100Km { get; set; }
        public double Kilomeetrid { get; set; }

        public Auto(double kutuseKulu100Km, double kilomeetrid)
        {
            KutuseKulu100Km = kutuseKulu100Km;
            Kilomeetrid = kilomeetrid;
        }

        // Arvutab auto kütusekulu liitrites
        public double ArvutaKulu()
        {
            return (KutuseKulu100Km / 100) * Kilomeetrid;
        }

        // Tagastab läbitud vahemaa
        public double ArvutaVahemaa()
        {
            return Kilomeetrid;
        }

        // Kuvab objekti info
        public override string ToString()
        {
            return $"Auto | Kulu: {ArvutaKulu():F2} l | Vahemaa: {Kilomeetrid} km";
        }
    }
}

