using System;
using System.Collections.Generic;
using System.Text;

namespace Soidukite_liidese_rakendamine
{
    public class Jalgratas : ISõiduk
    {
        public double Kilomeetrid { get; set; }

        public Jalgratas(double kilomeetrid)
        {
            Kilomeetrid = kilomeetrid;
        }

        // Jalgratas ei kasuta kütust
        public double ArvutaKulu()
        {
            return 0;
        }

        public double ArvutaVahemaa()
        {
            return Kilomeetrid;
        }

        public override string ToString()
        {
            return $"Jalgratas | Kulu: 0 l | Vahemaa: {Kilomeetrid} km";
        }
    }
}
