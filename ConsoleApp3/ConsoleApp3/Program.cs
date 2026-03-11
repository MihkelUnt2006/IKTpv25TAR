namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali  meetod");
            Console.WriteLine("1 - for loop");
            Console.WriteLine("2 - While meetod");
            Console.WriteLine("3 - liitmine");
            Console.WriteLine("4 - vanus");

            int valik = int.Parse(Console.ReadLine());

            if (valik == 1)
            {
                ForLoopMeetod();

            }
            else if (valik == 2)
            {
                WhileMethod();
            }
            else if (valik == 3)
            {
                Liitmine();
            }
            else if (valik == 4)
            {
                VanusMeetod();
            }
            else
            {
                Console.WriteLine("vale vastus");
            }
            static void ForLoopMeetod()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Hello for");
                }
            }
            static void WhileMethod()
            {
                int i = 0;
                while (i < 3)
                {
                    Console.WriteLine("hello while");
                    i++;
                }
            }
            static void Liitmine()
            {
                Console.WriteLine("sisesta number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("sisesta number");
                int b = int.Parse(Console.ReadLine());
                int summa = a + b;
                Console.WriteLine("summa " + summa);

            }
            static void VanusMeetod()
            {
                Console.WriteLine("sisesta enda vanus");
                string age = Console.ReadLine();
                Console.WriteLine("sinu vanus on " + age);

            }



        }
    }
}