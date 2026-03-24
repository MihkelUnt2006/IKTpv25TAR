using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static Naidis_IKTpv25.Person;

namespace Naidis_IKTpv25
{
    public class Osa5_start_page
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("osa5 funktsioonid");
            Console.WriteLine("1 - array näide");
            Console.WriteLine("2 - Tuple");
            Console.WriteLine("3 - list klassiga");
            Console.WriteLine("4 Linked list");
            Console.WriteLine("5 sonatlik");
            Console.WriteLine("6 - toidu salvestamine faili");
            Console.WriteLine("7 - kaalu kalk");
            Console.WriteLine("8  maakonnad");
            Console.WriteLine("9 - opilased");
            Console.WriteLine("10 tekstist arvud");
            Console.WriteLine("11 lemmik loomad");
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
                case "7":
                    while (true)
                        try
                        {
                            Console.Write("Sisesta oma nimi: ");
                            string nimi = Console.ReadLine();

                            Console.Write("Sisesta vanus: ");
                            int vanus = int.Parse(Console.ReadLine());
                            if (vanus < 0 && vanus > 100)
                            {
                                Console.WriteLine("Vanus peab olema vahemikus 0-100");
                                continue;
                            }

                            Console.Write("Sisesta sugu (mees/naine): ");
                            string sugu = Console.ReadLine().ToLower();
                            if (sugu != "mees" && sugu != "naine")
                            {
                                Console.WriteLine("Sugu peab olema 'mees' või 'naine'");
                                continue;
                            }

                            Console.Write("Sisesta pikkus (cm): ");
                            double pikkus = double.Parse(Console.ReadLine());
                            if (pikkus < 50 || pikkus > 250)
                            {
                                Console.WriteLine("Pikkus peab olema vahemikus 50-250 cm");
                                continue;
                            }

                            Console.Write("Sisesta kaal (kg): ");
                            double kaal = double.Parse(Console.ReadLine());
                            if (kaal < 20 || kaal > 300)
                            {
                                Console.WriteLine("Kaal peab olema vahemikus 20-300 kg");
                                continue;
                            }

                            Console.Write("Sisesta aktiivsustase (1-5): ");

                            int aktiivsustase = int.Parse(Console.ReadLine());
                            if (aktiivsustase < 1 || aktiivsustase > 5)
                            {
                                Console.WriteLine("Aktiivsustase peab olema vahemikus 1-5");
                                continue;
                            }
                            inimene_osa5 kasutaja = new inimene_osa5(nimi, vanus, sugu, pikkus, kaal, aktiivsustase);
                            ulesanded.KaalKalkulaator(kasutaja);
                            break;
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Vale andmed");
                        }



                    break;

                default:
                    Console.WriteLine("Valik puudub");
                    break;
                case "8":
                    ulesanded.Maakonnad_pealinnad();
                    break;

                case "9":
                    List<Naidis_IKTpv25.opilane> opilased = new List<Naidis_IKTpv25.opilane>();

                    for (int i = 0; i < 3; i++)
                    {
                        try
                        {
                            List<int> hinded = new List<int>();
                            Console.Write("Sisesta õpilase nimi: ");
                            string nimi = Console.ReadLine();
                            for (int j = 0; j < 5; j++)
                            {

                                Console.Write("Sisesta õpilase hinded (1-5): ");
                                int hinne = int.Parse(Console.ReadLine());
                                if (hinne > 1 || hinne < 5)
                                {
                                    hinded.Add(hinne);
                                }
                                else
                                {
                                    Console.WriteLine("Hinded peab olema vahemikus 1-5");
                                }

                            }
                            Naidis_IKTpv25.opilane uus_opilane = new Naidis_IKTpv25.opilane(nimi, hinded);
                            opilased.Add(uus_opilane);
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Vale andmed");

                        }

                    }
                    ulesanded.opilased(opilased);
                    break;



                case "10":
                    ulesanded.Tekstist_arvud();
                    break;

                case "11":
                    ulesanded.Lemmikloomade_register();

                    break;

            }
        }
    }
}

