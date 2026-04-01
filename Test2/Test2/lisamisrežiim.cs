using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Test2
{
    internal class lisamisrežiim
    {
        public static void lisamisrežiim(string teade)
        {
            string path = "logi.txt";
                using (StreamWriter sw = new StreamWriter(path, true))
            {
                string rida = $"[{DateTime.Now}] - {teade}";
                sw.WriteLine(rida);
            }
        }
    }
}
