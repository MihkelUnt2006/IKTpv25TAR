using System;
using System.Collections.Generic;
using System.Text;
using static Naidis_IKTpv25.Person;

namespace Naidis_IKTpv25
{
    public class Osa5_start_page
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("osa5 funktsioonid");

            string valik = Console.ReadLine();
            switch (valik)
            {

                case "1":
                    Osa5_funktsioonid.array_naide();
                    break;
                case "2":
                    Osa5_funktsioonid.Tuple();
                    break;
                case "3":
                    Person.List_klassiga();
                    break;
                case "4":
                    Osa5_funktsioonid.LinkedList();
                    break;
                case "5":
                    Osa5_funktsioonid.sonatlik();
                    break;
                case "6":
                    ulesanded.Toidu_salvestamine_faili();
                    break;



            }
        }
    }
}

