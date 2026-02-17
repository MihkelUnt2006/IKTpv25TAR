using System;
using System.Collections.Generic;
using System.Text;

public class Inimene
{
    public string Nimi;
    public int Vanus;
    public Inimene(string nimi, int vanus) { Nimi = nimi; Vanus = vanus; }
}

public class InimesteTootlus
{
    public Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
    {
        int sum = 0;
        Inimene vanim = inimesed[0], noorem = inimesed[0];
        foreach (Inimene isik in inimesed)
        {
            sum += isik.Vanus;
            if (isik.Vanus > vanim.Vanus) vanim = isik;
            if (isik.Vanus < noorem.Vanus) noorem = isik;
        }
        return Tuple.Create(sum, (double)sum / inimesed.Count, vanim, noorem);
    }

    public static void Run()
    {
        var inimesed = new List<Inimene>() { new Inimene("Mari", 25), new Inimene("Jaan", 40), new Inimene("Anna", 30) };
        var stat = new InimesteTootlus().Statistika(inimesed);
        Console.WriteLine($"Summa vanustest: {stat.Item1}, Keskmine: {stat.Item2}");
        Console.WriteLine($"Vanim: {stat.Item3.Nimi} ({stat.Item3.Vanus}), Noorem: {stat.Item4.Nimi} ({stat.Item4.Vanus})");
    }
}
