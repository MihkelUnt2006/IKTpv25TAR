using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    internal class RiigiOtsing
    {
        public static string RiigiOtsing()
        {
            try
            {
                Dictionary<string, string> RiigiOtsing = new Dictionary<string, string>()
                {
                    {"EE", "Estonia"},
                    {"FI", "Finland"},
                    {"LV", "latvia"}
                };

                Console.WriteLine("Sisesta RiigiKood");
                string input = Console.ReadLine();

                if (RiigiOtsing.ContainsKey(input))
                    Console.WriteLine("Riik" + RiigiOtsing[input]);
                else if (RiigiOtsing.ContainsValue(input))
                {
                    foreach (var kv in RiigiOtsing)
                        if (kv.Value == input)
                            Console.WriteLine("Riik: " + kv.Key);
                }
                else
                {
                        Console.WriteLine("Ei leitud, lisa uus.");
                        Console.Write("RiigiKood: ");
                        string K = Console.ReadLine();
                        RiigiOtsing[K] = K;
                    
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            return RiigiOtsing();
        }
    }
}
