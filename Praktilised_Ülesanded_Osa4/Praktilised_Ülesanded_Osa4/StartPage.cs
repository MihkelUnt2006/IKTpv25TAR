using Praktilised_ülesanded;
using System.ComponentModel.DataAnnotations;

namespace Praktilised_Ülesanded_Osa4
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali funktisoon");
            Console.WriteLine("1 - retsepti sisestamine");
            Console.WriteLine("2 - retsepti lugemine");
            Console.WriteLine("3 - koostis osade faili tekkimine");
            Console.WriteLine("4 - koostis osade lugemine");
            Console.WriteLine("5 - koostis osade muutmine ");
            Console.WriteLine("6 - Koostisosa otsing");
            int[] arvud = new int[5];
            string valik = Console.ReadLine();
            
            if (valik == "1")
            {
                ulesanded.retseptid();
            }
            else if (valik == "2")
            {
                ulesanded.retseptilistiavamine();
            }
            else if (valik == "3")
            {
                ulesanded.KoostisosadFail();
            }
            else if (valik == "4")
            {
                ulesanded.KoostisOsadelugemine();   
            }
            else if (valik == "5")
            {
                ulesanded.Koostisosademuutmine("KoostisOsad.txt");
            }
            else if (valik == "6")
            {
                ulesanded.Otsing("KoostisOsad.txt");
            }
            else if (valik == "7")
            {
                ulesanded.Koostisosadesalvestamine("KoostisOsad.txt");
            }
            else if (valik == "8")
            {
                menuUlesanne.MenuuUlesanne();
            }
            else
            {
                Console.WriteLine("viga");
            }
            
        }
    }
}
