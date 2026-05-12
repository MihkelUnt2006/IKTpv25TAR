using System;

class Kangelane
{
    private string nimi;
    private string asukoht;

    public Kangelane(string nimi, string asukoht)
    {
        this.nimi = nimi;
        this.asukoht = asukoht;
    }

    public string Nimi { get => nimi; set => nimi = value; }
    public string Asukoht { get => asukoht; set => asukoht = value; }

    public virtual int Paasta(int ohus)
    {
        return (int)Math.Round(ohus * 0.95);
    }

    public virtual string Vormiriietus()
    {
        return "Tavaline kangelase riietus";
    }

    public virtual string Tervitus()
    {
        return $"Tere! Mina olen {nimi}.";
    }

    public virtual string MissiooniStaatus()
    {
        return "Kättesaadav missioonide jaoks";
    }

    public override string ToString()
    {
        return $"Nimi: {nimi}, Asukoht: {asukoht}";
    }
}
