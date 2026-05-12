using System;

class SuperKangelane : Kangelane
{
    private static readonly Random rnd = new Random();
    public double Osavus { get; private set; }

    public SuperKangelane(string nimi, string asukoht) : base(nimi, asukoht)
    {
        // Osavus in [1.0, 5.0)
        Osavus = 1.0 + rnd.NextDouble() * 4.0;
    }

    public override int Paasta(int ohus)
    {
        double protsent = 95.0 + Osavus;
        return (int)Math.Round(ohus * (protsent / 100.0));
    }

    public override string Vormiriietus()
    {
        return "Eriline superkangelase kostüüm: kapuuts, mask ja draama";
    }

    public override string Tervitus()
    {
        return $"Ma olen super {Nimi} — valmis päästma maailma!";
    }

    public override string MissiooniStaatus()
    {
        return "Tõenäoliselt juba missioonil";
    }

    public override string ToString()
    {
        return base.ToString() + $", Osavus: {Osavus:F2}";
    }
}
