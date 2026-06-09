using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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

        // Harjutus 6: Ülelaaditud meetod - List<Isik> parameetriga
        public void LisaInimene(List<Isik> uuedInimesed)
        {
            inimesed.AddRange(uuedInimesed);
            Console.WriteLine($"Lisati {uuedInimesed.Count} uut inimest.");
        }

        public void KuvaKõik()
        {
            Console.WriteLine("\n--- KOOLI NIMEKIRI ---");
            foreach (var isik in inimesed)
            {
                // Polümorfism teeb siin imesid! 
                // C# teab ise, kas käivitada Õpetaja või Õpilase Kirjelda() meetod.
                Console.WriteLine(isik.Kirjelda());
            }
        }

        public void OtsiNimeJärgi(string otsitavNimi)
        {

            Console.WriteLine($"OTSINGU TULEMUSED (päring {otsitavNimi})");
            bool leitud = false;

            foreach (var isik in inimesed)
            {
                if (isik.Nimi.Contains(otsitavNimi, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(isik.Kirjelda());
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
                if (isik.Nimi.Contains(otsitavNimi)) Console.WriteLine(isik.Kirjelda());
            }
        }

        // 2. Otsing nimekirjas numbri/sünniaasta järgi (sama nimi, aga võtab vastu int)
        public void Otsi(int sünniaasta)
        {
            Console.WriteLine($"\nOtsime kedagi, kes on sündinud aastal: {sünniaasta}");
            Console.WriteLine($"\n--- OTSINGU TULEMUSED (Sünniaasta: {sünniaasta}) ---");
            bool leitud = false;

            foreach (var isik in inimesed)
            {
                if (isik.Sünniaasta == sünniaasta)
                {
                    Console.WriteLine(isik.Kirjelda());
                    Console.WriteLine("----------");
                    leitud = true;
                }
            }
            if (!leitud)
            {
                Console.WriteLine($"Aaastal {sünniaasta} sündinud isikuid nimekirjas ei ole.");
            }
        }

        // Harjutus 7: Salvestamine faili
        public void SalvestaFaili(string failinimi)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(failinimi, append: false, encoding: Encoding.UTF8))
                {
                    writer.WriteLine($"--- KOOLI NIMEKIRI (Salvestatud: {DateTime.Now}) ---");
                    writer.WriteLine();

                    foreach (var isik in inimesed)
                    {
                        writer.WriteLine(isik.Kirjelda());
                    }

                    writer.WriteLine();
                    writer.WriteLine($"Kokku {inimesed.Count} isikut");
                }
                Console.WriteLine($"Nimekiri salvestatud faili: {failinimi}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Faili kirjutamise viga: {ex.Message}");
            }
        }

        // Harjutus 9: Filtreerimine - ainult õpilased
        public void KuvaAinultÕpilased()
        {
            Console.WriteLine("\n--- AINULT ÕPILASED (foreach + is) ---");
            foreach (var isik in inimesed)
            {
                if (isik is Õpilane)
                {
                    Console.WriteLine(isik.Kirjelda());
                }
            }
            Console.WriteLine("\n--- AINULT ÕPILASED (LINQ) ---");
            inimesed.OfType<Õpilane>().ToList().ForEach(õ => Console.WriteLine(õ.Kirjelda()));

        }
    }
}
