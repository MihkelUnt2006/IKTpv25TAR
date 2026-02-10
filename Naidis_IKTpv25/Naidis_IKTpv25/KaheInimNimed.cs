using System;

public class Class1
{
	public Class1()
	{
		static void Main()
		{
            Console.WriteLine("Sisesta esimene nimi: ");
			string nimi1 = Console.ReadLine();

			Console.WriteLine("Sisesta teine nimi:");	
			string nimi2 = Console.ReadLine();

			if ( nimi1 != "" && nimi2 != "")
			{
                Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid ");
			}
			else
			{
                Console.WriteLine("Palun sisesta mõlema inimese nimed ");
			}
        }

	}
}
