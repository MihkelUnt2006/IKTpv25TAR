namespace ITaaliaToit
{
    internal class MainPage_classidega
    {
      public  static void Main(string[] args)
      {
            bool tootab = true;
            ItaaliaFunktsioonid_klassidega.LaeAndmedFailist();
            while(true)
            Console.WriteLine("Tere tulemast Itaalia restorani");
            Console.WriteLine("1. Laemine anmeid failist ");
            Console.WriteLine("2. Menüü vaatmine ");
            Console.WriteLine("3. Uue toidu lisamine");
            Console.WriteLine("4. Amdmete salvestamine");
            int valik = int.Parse(Console.ReadLine());
            switch (valik)
            {
                case 1:
                    ItaaliaFunktsioonid_klassidega.LaeAndmedFailist();
                    break;
                case 2:
                    ItaaliaFunktsioonid_klassidega.ItaaliaRestoran();
                    break;
                case 3:
                    ItaaliaFunktsioonid_klassidega.LisaUusToit();
                    break;
                case 4:
                    ItaaliaFunktsioonid_klassidega.SalvestAndmedFaili();
                    break;
                case 5:
                    ItaaliaFunktsioonid_klassidega.KustutaToit();
                case 6:
                    ItaaliaFunktsioonid_klassidega.ToiduInformatsioon();
                    break;

            }
      }
      
        
        
    }
}
