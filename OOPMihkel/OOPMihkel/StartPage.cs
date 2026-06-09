using System.Globalization;
using System.Reflection.Metadata;

namespace OOPMihkel
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            Koolihaldus minuKool = new Koolihaldus();
            
            Console.ReadLine();

            List<ITööline> palgasaajad = new List<ITööline>();
            Random rnd = new Random();

            Õpilane õpilane1 = new Õpilane();
            õpilane1.Nimi = "TImoga";
            õpilane1.Sünniaasta = 2009;
            õpilane1.Kool = "TTHK";
            õpilane1.Klass = 10;
            õpilane1.Tervita();
            õpilane1.Õpi();
            Console.WriteLine(õpilane1.Kirjelda());

            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Nimi = "Markus";
            õpetaja1.Sünniaasta = 1989;
            õpetaja1.Aine = "Matemaatika";
            õpetaja1.Õpeta();
            Console.WriteLine(õpetaja1.Kirjelda());

            Õpilane õpilane2 = new Õpilane();
            õpilane2.Nimi = "Mati";
            õpilane2.KeskmineHinne = 4.0;
            õpilane2.Puudumised = 10;

            Õpilane õpilane3 = new Õpilane();
            õpilane3.Nimi = "Kati";
            õpilane3.KeskmineHinne = 3.0;
            õpilane3.Puudumised = 40;
            õpilane3.Staatus = Õppevorm.Päevane;

            Õpetaja õpetaja2 = new Õpetaja();
            õpetaja2.Nimi = "Markus";
            õpetaja2.Sünniaasta = 1989;
            õpetaja2.Aine = "Matemaatika";
            õpetaja2.Tunnitasu = 10.5;
            õpetaja2.Tunnidkuus = 40;

            //Õpetajad
            string[] õpetajaNimed = { "Marina", "Aleksei", "Katrin", "Dmitri", "Liisa" };
            int[] õpetajaSünniaastad = { 1975, 1982, 1990, 1995, 1988 };
            string[] ained = { "programmeerimine", "matemaatika", "füüsika", "keemia", "eesti keel" };
            double[] tunnitasud = { 13.8, 15.0, 12.5, 14.2, 16.0 };
            int[] tunnidKuus = { 120, 130, 140, 150, 160 };
            string[] hinne = { "1", "2", "3", "4", "5" };

            //Õpilased
            string[] õpilasNimed = { "Yaroslav", "Anna", "Peeter", "Maria", "Ivan" };
            int[] õpilasSünniaastad = { 2005, 2006, 2007, 2008, 2009 };
            string[] koolid = { "TTHK", "Gustav Adolfi Gümnaasium", "Tallinna Reaalkool" };
            int[] klassid = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] puudumised = { 0, 5, 10, 13, 20 };

            //Üliõpilane
            string[] kuurs = { "1", "2", "3", "4", "5" };

            //Direktor
            double[] lisatasu = { 100, 200, 300, 400, 500 };

            Õppevorm[] vormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm));

            Direktor direktor = new Direktor();
            direktor.Nimi = õpetajaNimed[rnd.Next(1, 5)];
            direktor.Sünniaasta = õpetajaSünniaastad[rnd.Next(1, 5)];
            direktor.Tunnitasu = tunnitasud[rnd.Next(1, 5)];
            direktor.Tunnidkuus = tunnidKuus[rnd.Next(1, 5)];
            direktor.Lisatasu = lisatasu[rnd.Next(1, 5)];
            palgasaajad.Add(direktor);
            direktor.ArvutaPalk();
            Console.WriteLine(direktor.Kirjelda());

            palgasaajad.AddRange(new ITööline[] { õpilane2, õpilane3, õpetaja2 });
            
            ITööline[] toolised = new ITööline[3];
            string[] nimed = { "Maria", "Kati", "Juhan", "Anna", "Siim" };
            
            for (int i = 0; i < nimed.Length; i++)
            {
                Õpilane õpilane = new Õpilane
                {
                    Nimi = nimed[rnd.Next(nimed.Length)],
                    Klass = rnd.Next(1, 13),
                    Kool = "TTHK",
                    KeskmineHinne = rnd.NextDouble() * 5,
                    Puudumised = rnd.Next(0, 350),
                    KasOnSotsTõend = rnd.Next(0, 2) == 1,
                    Staatus = vormid[rnd.Next(vormid.Length)]
                };
                palgasaajad.Add(õpilane);
            }

            // 🔹 Tsükkel
            Console.WriteLine("---väljamaksed---");
            foreach (ITööline isik in palgasaajad)
            {
                string tüüp = isik.VäljamakseTüüp.ToString();
                Console.WriteLine($" {tüüp}  summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}");
            }

            // Harjutus 5: Kasutame uut konstruktorit
            Õpetaja op = new Õpetaja("Mati", "Programmeerimine", 12.5);
            Õpilane opilane1 = new Õpilane { Nimi = "Mari", Klass = 10, Staatus = Õppevorm.Päevane };

            minuKool.LisaInimene(õpilane2);
            minuKool.LisaInimene(õpilane3);
            minuKool.LisaInimene(õpetaja2);

            minuKool.LisaInimene(op);
            minuKool.LisaInimene(opilane1);
            foreach (ITööline isik in palgasaajad)
            {
                minuKool.LisaInimene(((Isik)isik));
            }

            Õpilane olga = new Õpilane("Olga", "TTHK", 9);
            minuKool.LisaInimene(olga);

            Õpetaja Andrus = new Õpetaja("Andrus", "Inglise keel", 8.5);
            minuKool.LisaInimene(Andrus);
            
            minuKool.KuvaKõik();

            Console.WriteLine("\n--- LisaInimene(List<Isik>) ---");
            List<Isik> uuedInimesed = new List<Isik>
            {
                new Õpilane("Peeter", "TTHK", 11),
                new Õpilane("Sandra", "TTHK", 12),
                new Õpetaja("Moonika", "Keemia", 12.0)
            };
            minuKool.LisaInimene(uuedInimesed); // Harjutus 6: ülelaaditud meetod – lisa list korraga
            Console.WriteLine("3 uut inimest lisatud korraga listiga!");
            
            Console.WriteLine("\n--- SalvestaFaili ---");
            minuKool.SalvestaFaili("kooli_nimekiri.txt"); // Harjutus 7

            minuKool.Otsi(1989);

            Console.WriteLine($"Koolis on hetkel süsteemis registreeritud {Isik.InimesteKoguarv} isikut.");
            Console.WriteLine("\n--- KuvaAinultÕpilased ---"); // Harjutus 9
            minuKool.KuvaAinultÕpilased();

            // Harjutus 10: Kursus ja seosed
            Console.WriteLine("\n--- HARJUTUS 10: KURSUSE JA ÕPETAJA SEOS ---");
            Õpetaja matemaatika_Õpetaja = new Õpetaja("Jüri", "Matemaatika", 15.0);
            Kursus matemaatika_Kursus = new Kursus("Matemaatika Algkursus", matemaatika_Õpetaja);
            matemaatika_Kursus.KuvaInfo();

            // Harjutus 8: Exception Handling
            Console.WriteLine("\n--- HARJUTUS 8: EXCEPTION HANDLING ---");
            Õpilane testÕpilane = new Õpilane();
            testÕpilane.Nimi = "Test Õpilane";
            try
            {
                testÕpilane.Sünniaasta = 2030; // Vigane - tulevikus
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Viga: {ex.Message}");
            }

            try
            {
                testÕpilane.Sünniaasta = 1850; // Vigane - liiga kaua aega tagasi
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Viga: {ex.Message}");
            }

            try
            {
                testÕpilane.Sünniaasta = 2008; // Kehtiv
                Console.WriteLine($"Sünniaasta õigesti määratud: {testÕpilane.Sünniaasta}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Viga: {ex.Message}");
            }
        }
    }
}
