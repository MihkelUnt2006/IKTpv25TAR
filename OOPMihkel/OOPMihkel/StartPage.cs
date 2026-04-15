using System.Globalization;
using System.Reflection.Metadata;

namespace OOPMihkel
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            //Isik inimene1 = new Isik();
           
            //inimene1.Nimi = "Mati";
            //inimene1.Sünniaasta = 2026;
            //inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...

            Õpilane õpilane1 = new Õpilane();
            õpilane1.Nimi = "TImoga";
            õpilane1.Sünniaasta = 2009;
            õpilane1.Kool = "TTHK";
            õpilane1.Klass = 10;
            õpilane1.Tervita();
            õpilane1.Õpi();
            õpilane1.Kirjelda();

            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Nimi = "Markus";
            õpetaja1.Sünniaasta = 1989;
            õpetaja1.Aine = "Matemaatika";
            õpetaja1.Õpeta();
            õpetaja1.Kirjelda();

            Console.ReadLine();



            List<ITööline> palgasaajad = new List<ITööline>();

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
            

           




            palgasaajad.AddRange(new ITööline[] { õpilane2, õpilane3, õpetaja2 });
            Random rnd = new Random();
            string[] nimed = { "Maria", "Kati", "Juhan", "Anna", "Siim" };
            Õppevorm[] vormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm));
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
            //
            Koolihaldus minuKool = new Koolihaldus();

            Õpetaja op = new Õpetaja { Nimi = "Mati", Aine = "Programmeerimine" };
            Õpilane opilane1 = new Õpilane { Nimi = "Mari", Klass = 10, Staatus = Õppevorm.Päevane };
            minuKool.LisaInimene(õpilane1);
            minuKool.LisaInimene(õpetaja1);

            minuKool.LisaInimene(õpilane2);
            minuKool.LisaInimene(õpilane3);
            minuKool.LisaInimene(õpetaja2);



            minuKool.LisaInimene(op);
            minuKool.LisaInimene(opilane1);
            foreach (ITööline isik in palgasaajad)
            {
                
                    minuKool.LisaInimene(((Isik)isik));
                
            }

            minuKool.KuvaKõik();

                


        }
    }
}
