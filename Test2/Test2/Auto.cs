using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Test2
{
    internal class Auto
    {
        string Mark { get; set; }
        string KutseKulu { get; set; }
        string PagisOnKutsus { get; set; }
        
        int Soiduulatus;
        int Aasta;
     
        

        public Auto(string mark, double kulu, double pagis)
        { 
            Mark = mark;
            KutseKulu = kulu;
            PagisOnKutsus = pagis;
        }

        public double Soiduulatus()
        {
            return PagisOnKutsus / KutseKulu * 100;
        }

        public static void benzo()
        {
            List<Auto> filmid = new List<Auto>()
        {
            new Auto{"BMW", 1998,  6.4},
            new Auto{"Toyota", 1997,  7.2},
            new Auto{"Mercedes", 2009,  8.0 },
            new Auto{"Audi", 2019, 7.1},
            new Auto{"Škoda", 2022, 6.5 }
        };

            Auto parim = Autod[0];
            foreach (var a in Autod)
            {
                
            }
        }
        }
}
