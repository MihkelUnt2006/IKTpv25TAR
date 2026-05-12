using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static List<Kangelane> kangelased = new List<Kangelane>();

    public static void LoeKangelasedFailist(string failinimi)
    {
        if (!File.Exists(failinimi))
        {
            // Try relative to project directory
            var alt = Path.Combine(AppContext.BaseDirectory, failinimi);
            if (File.Exists(alt))
                failinimi = alt;
            else
            {
                Console.WriteLine($"Faili ei leitud: {failinimi}");
                return;
            }
        }

        var lines = File.ReadAllLines(failinimi);
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            // Expect format: Name[*] / Location
            var parts = line.Split('/');
            if (parts.Length < 2) continue;
            var namePart = parts[0].Trim();
            var location = parts[1].Trim();

            if (namePart.Contains('*'))
            {
                var name = namePart.Replace("*", "").Trim();
                kangelased.Add(new SuperKangelane(name, location));
            }
            else
            {
                kangelased.Add(new Kangelane(namePart, location));
            }
        }
    }

    static void Main()
    {
        LoeKangelasedFailist("andmed.txt");

        var tavakangelane = kangelased.OfType<Kangelane>().FirstOrDefault(k => !(k is SuperKangelane));
        var superkangelane = kangelased.OfType<SuperKangelane>().FirstOrDefault();

        if (tavakangelane != null)
        {
            Console.WriteLine("--- Tavakangelane ---");
            Console.WriteLine(tavakangelane.ToString());
            Console.WriteLine($"Paastas: {tavakangelane.Paasta(1000)} inimest");
            Console.WriteLine(tavakangelane.Vormiriietus());
            Console.WriteLine(tavakangelane.Tervitus());
            Console.WriteLine(tavakangelane.MissiooniStaatus());
        }

        if (superkangelane != null)
        {
            Console.WriteLine("\n--- Superkangelane ---");
            Console.WriteLine(superkangelane.ToString());
            Console.WriteLine($"Paastas: {superkangelane.Paasta(1000)} inimest");
            Console.WriteLine(superkangelane.Vormiriietus());
            Console.WriteLine(superkangelane.Tervitus());
            Console.WriteLine(superkangelane.MissiooniStaatus());
        }

        // Kuvame kõigi kangelaste päästetud inimeste koguarvu ntx ohus=1000
        int kokku = kangelased.Sum(k => k.Paasta(1000));
        Console.WriteLine($"\nKokku päästetud inimesi (igaühe ohus=1000): {kokku}");
    }
}
