namespace Test2
{
    internal class StartPage
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== MENÜÜ ===");
                Console.WriteLine("1 - lisamisrežiimFailidega");
                Console.WriteLine("2 - Dictionary");
                Console.WriteLine("3 - StreamReader");
                Console.WriteLine("4 - Auto");
                Console.WriteLine("0 - Välju");

                string valik = Console.ReadLine();
                switch(valik)
                {
                    case "1":
                        lisamisrežiim.lisamisrežiim();
                        break;
                    case "2":
                        RiigiOtsing.RiigiOtsing();
                            break;
                    case "3":
                        StreamReader.StreamReaderMeetod();
                            break;
                    case "4":
                        Auto.AutoMeetod();
                            break;
                    case "0":
                        return;

                }
            }
    }
}
}

