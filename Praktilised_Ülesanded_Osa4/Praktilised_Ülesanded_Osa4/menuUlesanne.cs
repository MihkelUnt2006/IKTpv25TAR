using System;
using System.Collections.Generic;
using System.Text;

namespace Praktilised_ülesanded
{
    public class menuUlesanne
    {
        
    public static void MenuuUlesanne()
        {
            List<Tuple<string, string, double>> menuuList = new List<Tuple<string, string, double>>();

            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Menuu.txt");

                string[] read = File.ReadAllLines(path);

                foreach (string rida in read)
                {
                    string[] osad = rida.Split(';');

                    string nimi = osad[0];
                    string koostisosad = osad[1];
                    double hind = double.Parse(osad[2]);

                    menuuList.Add(Tuple.Create(nimi, koostisosad, hind));
                }

                Console.WriteLine("------ ITAALIA RESTORANI MENÜÜ ------\n");

                foreach (var toit in menuuList)
                {
                    Console.WriteLine($"{toit.Item1.PadRight(30)} {toit.Item3} €");
                    Console.WriteLine($"   Koostisosad: {toit.Item2}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
