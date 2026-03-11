using System;

static void ristkylik()
{
    Console.WriteLine("Sisesta arv A");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Siseta arv B");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Sisesta arv C");
    double c = Convert.ToDouble(Console.ReadLine());

    double D = b * b - 4 * a * c;

    if (D > 0)
    {
        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine("Lahendid: x1 = " + x1 + ", x2 = " + x2);
    }
    else if (D == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine("Üks lahend: x = " + x);
    }
    else
    {
        Console.WriteLine("Lahendeid pole");
    }

    Console.WriteLine("Hello, World!");
}