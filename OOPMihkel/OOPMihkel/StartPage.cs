namespace OOPMihkel
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            Isik inimene1 = new Isik();
            inimene1.Nimi = "Mati";
            inimene1.Sünniaasta = 2026;
            inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...
        }
    }
}
