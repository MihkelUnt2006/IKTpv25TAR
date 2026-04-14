namespace OOPMihkel
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            //Isik inimene1 = new Isik();
           
            //inimene1.Nimi = "Mati";
            //inimene1.Sünniaasta = 2026;
            //inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...

            Õpilane õpilane1 = new Õpilane();
            õpilane1.Nimi = "TImoga";
            õpilane1.Sünniaasta = 2009;
            õpilane1.Kool = "TTHK";
            õpilane1.Klass = 10;
            õpilane1.Tervita();
            õpilane1.Õpi();
            õpilane1.Kirjelda();

            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Nimi = "Markus";
            õpetaja1.Sünniaasta = 1989;
            õpetaja1.Aine = "Matemaatika";
            õpetaja1.Õpeta();
            õpetaja1.Kirjelda();

            Console.ReadLine();






        }
    }
}
