   
using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
   


class Program
    {
        static void Main(string[] args)
        {
            // List sõidukite hoidmiseks
            List<ISõiduk> soidukid = new List<ISõiduk>();

            // Muutuja kogu kulu jaoks
            double koguKulu = 0;

            try
            {
                // Loeme kõik read failist
                string[] read = File.ReadAllLines("andmed.txt");

                // Käime kõik read läbi
                foreach (string rida in read)
                {
                    // Jagame rea osadeks
                    string[] andmed = rida.Split(',');

                    // Kontrollime sõiduki tüüpi
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
        }
    }
}

