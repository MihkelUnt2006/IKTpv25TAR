using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Soidukite_liidese_rakendamine;
using System.ComponentModel;

// List sõidukite hoidmiseks
List<ISõiduk> soidukid = new List<ISõiduk>();

// Muutuja kogu kulu jaoks
double koguKulu = 0;
soidukid.Add(new Auto(7, 200));
soidukid.Add(new Jalgratas(50));
soidukid.Add(new Buss(20, 300, 1.8, 40));
soidukid.Add(new Mootorratas(5, 150));
soidukid.Add(new Auto(6.8, 25));
string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "andmed.txt");


try
{

    List<string> lines = new List<string>();

    foreach (ISõiduk s in soidukid)
    {
        lines.Add(s.ToString());
    }

    File.AppendAllLines(path, lines);

    Console.WriteLine("Andmed lisati faili.");

    File.WriteAllLines(path, lines);

    Console.WriteLine("Andmed on salvestatud.");
    string[] read = File.ReadAllLines(path);
    // Käime kõik read läbi
    foreach (string rida in read)
    {
        if (string.IsNullOrWhiteSpace(rida))
            continue;

        // Jagame rea osadeks semikooloni järgi
        string[] andmed = rida.Split(';');

        // Kontrollime sõiduki tüüpi ja valideerime välju
        switch (andmed[0])
        {
            case "Auto":

                // Loome auto objekti
                Auto auto = new Auto(
                    double.Parse(andmed[1]),
                    double.Parse(andmed[2])
                );

                soidukid.Add(auto);
                break;

            case "Jalgratas":

                Jalgratas jalgratas = new Jalgratas(
                    double.Parse(andmed[1])
                );

                soidukid.Add(jalgratas);
                break;

            case "Buss":

                Buss buss = new Buss(
                    double.Parse(andmed[1]),
                    double.Parse(andmed[2]),
                    double.Parse(andmed[3]),
                    int.Parse(andmed[4])
                );

                soidukid.Add(buss);
                break;

            case "Mootorratas":

                Mootorratas mootorratas = new Mootorratas(
                    double.Parse(andmed[1]),
                    double.Parse(andmed[2])
                );

                soidukid.Add(mootorratas);
                break;
        }
    }

    Console.WriteLine("---- TULEMUSED ----");

    // Kuvame kõik sõidukid
    foreach (ISõiduk s in soidukid)
    {
        Console.WriteLine(s);

        // Liidame kogukulu
        koguKulu += s.ArvutaKulu();
    }

    // Kuvame kõikide sõidukite kogukulu
    Console.WriteLine("\nKogu kulu kokku: " + koguKulu.ToString("F2"));

    // MENÜÜ: lase kasutajal lisada sõidukeid käsitsi
    while (true)
    {
        Console.WriteLine("\n--- MENÜÜ ---");
        Console.WriteLine("1 - Lisa Auto");
        Console.WriteLine("2 - Lisa Jalgratas");
        Console.WriteLine("3 - Lisa Buss");
        Console.WriteLine("4 - Lisa Mootorratas");
        Console.WriteLine("5 - Näita tulemusi");
        Console.WriteLine("0 - Välju");
        Console.Write("Vali: ");
        string valik = Console.ReadLine();

        if (valik == "0")
            break;

        switch (valik)
        {
            case "1": // Auto
                Console.Write("Sisesta kütusekulu 100km kohta: ");
                string ak = Console.ReadLine();
                Console.Write("Sisesta läbitud km: ");
                string akm = Console.ReadLine();

                if (double.TryParse(ak, out double aKulu) && double.TryParse(akm, out double aKmValue))
                {
                    var a = new Auto(aKulu, aKmValue);

                    soidukid.Add(a);

                    File.AppendAllText(path, a.ToString() + Environment.NewLine);

                    koguKulu += a.ArvutaKulu();

                    Console.WriteLine("Lisatud: " + a);
                }
                else Console.WriteLine("Vigased sisendid (Auto).");
                break;

            case "2": // Jalgratas
                Console.Write("Sisesta läbitud km: ");
                string jk = Console.ReadLine();
                if (double.TryParse(jk, out double jKmValue))
                {
                    var j = new Jalgratas(jKmValue);

                    soidukid.Add(j);

                    File.AppendAllText(path, j.ToString() + Environment.NewLine);

                    koguKulu += j.ArvutaKulu();

                    Console.WriteLine("Lisatud: " + j);
                }
                else Console.WriteLine("Vigased sisendid (Jalgratas).");
                break;

            case "3": // Buss
                Console.Write("Sisesta kütusekulu 100km kohta: ");
                string bk = Console.ReadLine();
                Console.Write("Sisesta läbitud km: ");
                string bkm = Console.ReadLine();
                Console.Write("Sisesta kütuse hind: ");
                string bh = Console.ReadLine();
                Console.Write("Sisesta reisijate arv: ");
                string br = Console.ReadLine();

                if (double.TryParse(bk, out double bKulu) &&
                    double.TryParse(bkm, out double bKmValue) &&
                    double.TryParse(bh, out double bHindValue) &&
                    int.TryParse(br, out int bReisijad) && bReisijad > 0)
                {
                    var b = new Buss(bKulu, bKmValue, bHindValue, bReisijad);

                    soidukid.Add(b);

                    File.AppendAllText(path, b.ToString() + Environment.NewLine);

                    koguKulu += b.ArvutaKulu();

                    Console.WriteLine("Lisatud: " + b);
                }
                else Console.WriteLine("Vigased sisendid (Buss).");
                break;

            case "4": // Mootorratas
                Console.Write("Sisesta kütusekulu 100km kohta: ");
                string mk = Console.ReadLine();
                Console.Write("Sisesta läbitud km: ");
                string mkm = Console.ReadLine();

                if (double.TryParse(mk, out double mKulu) &&
                    double.TryParse(mkm, out double mKmValue))
                {
                    var m = new Mootorratas(mKulu, mKmValue);

                    soidukid.Add(m);

                    File.AppendAllText(path, m.ToString() + Environment.NewLine);

                    koguKulu += m.ArvutaKulu();

                    Console.WriteLine("Lisatud: " + m);
                }
                else Console.WriteLine("Vigased sisendid (Mootorratas).");
                break;

            case "5":
                Console.WriteLine("---- TULEMUSED ----");
                foreach (ISõiduk s in soidukid)
                    Console.WriteLine(s);
                Console.WriteLine("Kogu kulu kokku: " + koguKulu.ToString("F2"));
                break;

            default:
                Console.WriteLine("Tundmatu valik");
                break;
        }
    }
}

// Veakontroll
catch (FileNotFoundException)
{
    Console.WriteLine("Faili ei leitud!");
}
catch (FormatException)
{
    Console.WriteLine("Failis on vigased andmed!");
}
catch (Exception ex)
{
    Console.WriteLine("Tekkis viga: " + ex.Message);
}
