using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMihkel
{
    public class Üliõpilane : Õpilane
    {
        public string Eriala { get; set; }
        public string Kuurs { get; set; }

        public override string Kirjelda()
        {
            return $"Üliõpilane {Nimi} õpib {Kuurs}. Kuursusel. Vorm: {Staatus}";
        }
    }
}
