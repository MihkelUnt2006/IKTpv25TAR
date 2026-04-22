using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMihkel
{
    public class Koolihaldus
    {
        
        // Kapseldatud list
        private List<Isik> inimesed = new List<Isik>();

        public List<Isik> Inimesed => inimesed;

        public void LisaInimene(Isik isik)
        {
            inimesed.Add(isik);
        }

        public void KuvaKõik()
        {
            Console.WriteLine("\n--- KOOLI NIMEKIRI ---");
            foreach (var isik in inimesed)
            {
                // Polümorfism teeb siin imesid! 
                // C# teab ise, kas käivitada Õpetaja või Õpilase Kirjelda() meetod.
                isik.Kirjelda();
            }
        }
        public void LisaInimene(List<Isik> uuedInimesed)
        {
            inimesed.AddRange(uuedInimesed);
            Console.WriteLine($"Lisati {uuedInimesed.Count} uut inimest.");
        }
        public void OtsiNimeJärgi(string otsitavNimi)
        {

            Console.WriteLine($"OTSINGU TULEMUSED (päring {otsitavNimi})");
            bool leitud = false;

            foreach (var isik in inimesed)
            {
                if (isik.Nimi.Contains(otsitavNimi, StringComparison.OrdinalIgnoreCase))
                {
                    isik.Kirjelda();
                    Console.WriteLine("--------");
                    leitud = true;
                }

            }
        }
        // 1. Otsing nime järgi (võtab vastu stringi)
        public void Otsi(string otsitavNimi)
        {
            Console.WriteLine($"\nOtsime nime: {otsitavNimi}");
            foreach (var isik in inimesed)
            {
                if (isik.Nimi.Contains(otsitavNimi)) isik.Kirjelda();
            }
        }

        // 2. Otsing nimekirjas numbri/sünniaasta järgi (sama nimi, aga võtab vastu int)
        public void Otsi(int sünniaasta)
        {
            Console.WriteLine($"\nOtsime kedagi, kes on sündinud aastal: {sünniaasta}");
            Console.WriteLine($"\n--- OTSINGU TULEMUSED (Sünniaasta: {sünniaasta}) ---");
            bool leitud = false;

            foreach(var isik in inimesed)
            {
                if(isik.Sünniaasta == sünniaasta)
                {
                    isik.Kirjelda();
                    Console.WriteLine("----------");
                    leitud = true;
                }
            }
            if (!leitud)
            {
                Console.WriteLine($"Aaastal {sünniaasta} sündinud isikuid nimekirjas ei ole.");
            }
        }
        public void SalvestaFaili(string failinimi)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(failinimi, append: false, encoding: Encoding.UTF8))
                {
                    writer.WriteLine($"--- KOOLI NIMEKIRI (Salvestatud: {DateTime.Now}) ---")
                    TextWriter vanaVäljund = Console.Out;
                    Console.SetOut(writer);

                    foreach (var isik in inimesed)
                    {
                        isik.Kirjelda();
                    }

                    Console.SetOut(vanaVäljund);
                }
                Console.WriteLine($"Nimekiri salvestatud faili: {failinimi}");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"Faili kirjutamise viga: {ex.Message}");
            }
        }

    }
}
