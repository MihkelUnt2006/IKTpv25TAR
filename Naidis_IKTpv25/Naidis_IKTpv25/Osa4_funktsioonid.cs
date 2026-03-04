using System;

public class Osa4_funktsioonid
{
    public static void tekstisisestamine()
    {
        try
        {
            string path = @"/Users/opilane/Desktop/Fail.txt"; //@"..\..\..\Kuud.txt"
            StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
            Console.WriteLine("Sisesta mingi tekst: ");
            string lause = Console.ReadLine();
            text.WriteLine(lause);
            text.Close();
        }
        catch (Exception)
        {
            Console.WriteLine("Mingi viga failiga");
        }
    }
    public static void Tekstilugemine()
    {
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
            StreamReader text = new StreamReader(path);
            string laused = text.ReadToEnd();
            text.Close();
            Console.WriteLine(laused);
        }
        catch (Exception)
        {
            Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
        }
    }
    public static void Ridade_lugemine(string file)
    {
        List<string> kuude_list = new List<string>();
        try
        {
            string path = @$"..\..\..\{file}";
            ;
            foreach (string rida in File.ReadAllLines(path))
            {
                kuude_list.Add(rida);
            }
            foreach (string i in kuude_list) Console.WriteLine(i);
        }
        catch (Exception)
        {
            Console.WriteLine("Viga failiga");
        }

    }
    public static void Ridade_lugemine_listiks(string file)
    {
        List<string> kuude_list = new List<string>();
        try
        {
            string path = @$"..\..\..\{file}";
            ;
            foreach (string rida in File.ReadAllLines(path))
            {
                kuude_list.Add(rida);
            }
            
        }
        catch (Exception)
        {
            Console.WriteLine("Viga failiga");
        }
    }

}
