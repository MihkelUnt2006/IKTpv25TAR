namespace OOP_geo
{
    public class StartPage
    {
        public static void Main()
        {
            // Ühine nimekiri kõikide liidest rakendavate objektide jaoks
            List<IKujund> kujundid = new List<IKujund>();

            while (true) // Lõputu tsükkel, kuni kasutaja valib 0
            {
                Console.WriteLine("\nVali kujund: 1=Ruut, 2=Ring, 3=Kolmnurk, 4=Ristkülik, 0=Välju");
                string valik = Console.ReadLine();

                if (valik == "0") break; // Murrame tsüklist välja

                switch (valik)
                {
                    case "1": // Ruut
                        Console.Write("Sisesta ruudu küljepikkus: ");
                        if (double.TryParse(Console.ReadLine(), out double külg))
                        {
                            kujundid.Add(new Ruut(külg));
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Vigane sisend! Palun sisesta number.");
                        }
                        break;

                    case "2": // Ring
                        Console.Write("Sisesta ringi raadius: ");
                        if (double.TryParse(Console.ReadLine(), out double raadius))
                        {
                            kujundid.Add(new Ring(raadius));
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Vigane sisend! Palun sisesta number.");
                        }
                        break;

                    case "3":
                        Console.Write("Sisesta külg a: ");
                        bool aOk = double.TryParse(Console.ReadLine(), out double a);

                        Console.Write("Sisesta külg b: ");
                        bool bOk = double.TryParse(Console.ReadLine(), out double b);

                        Console.Write("Sisesta külg c: ");
                        bool cOk = double.TryParse(Console.ReadLine(), out double c);

                        if (aOk && bOk && cOk)
                        {
                            kujundid.Add(new Kolmnurk(a, b, c));
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Vigane sisend! Palun sisesta number.");
                        }
                        break;

                    case "4": // Ristkülik
                        Console.Write("Sisesta ristküliku pikkus: ");
                        bool pikkusOk = double.TryParse(Console.ReadLine(), out double pikkus);

                        Console.Write("Sisesta ristküliku laius: ");
                        bool laiusOk = double.TryParse(Console.ReadLine(), out double laius);

                        if (pikkusOk && laiusOk)
                        {
                            kujundid.Add(new Ristkülik(pikkus, laius));
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Vigane sisend! Pikkus ja laius peavad olema numbrid.");
                        }
                        break;

                    default:
                        Console.WriteLine("Tundmatu valik.");
                        break;
                }
            }

            // Tulemuste kuvamine
            // Tulemuste kuvamine
            Console.WriteLine("\n--- Kujundite tulemused ---");
            foreach (var kujund in kujundid)
            {
                // Polümorfism: Iga kujund arvutab pindala ja ümbermõõdu oma spetsiifilise valemi järgi!
                // kujund.GetType().Name annab meile klassi nime (nt "Ruut" või "Ring")
                // :F2 ümardab tulemused 2 komakohani
                //Console.WriteLine($"Tüüp: {kujund.GetType().Name} | Pindala: {kujund.ArvutaPindala():F2} | Ümbermõõt: {kujund.ArvutaÜmbermõõt():F2}");

                string nimi = kujund.GetType().Name;
                double pindala = kujund.ArvutaPindala();
                double ümbermõõt = kujund.ArvutaÜmbermõõt();

                string rida = $"Tüüp: {nimi,-10} | Pindala: {pindala,8:F2} | Ümbermõõt: {ümbermõõt,8:F2}";

                // KONTROLL: Kas see kujund on tegelikult Kolmnurk?
                // Kasutame 'Pattern Matching' (kujund is Kolmnurk k)
                if (kujund is Kolmnurk k)
                {
                    // Nüüd me saame kasutada muutujat 'k', et küsida Kolmnurga omadusi
                    rida += $" | Liik: {k.Tüüp}";
                }
                Console.WriteLine(rida);
            }

        }

    }
}
