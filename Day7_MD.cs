using System;
using System.Collections.Generic;

namespace Day7_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            List2();
        }

        static void List2()
        {
            List<int> l = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                l.Add(random.Next(51));

            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Sveiki! Ko Jūs vēlaties izdarīt?");
                Console.WriteLine("Uzspiežot 1 - izvadīt sarakstu");
                Console.WriteLine("Uzspiežot 2 - izdzēst kādu elementu no saraksta pēc indeksa");
                Console.WriteLine("Uzspiežot 3 - iziet no šīs programmas");

                String ievade = Console.ReadLine();
                if (ievade == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Dotā brīža saraksts: ");
                    foreach (int a in l)
                    {
                        Console.WriteLine(a);
                    }

                }
                else if (ievade == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Ievadiet, kāda indeksa skaitli Jūs vēlaties izdzēst");

                    try
                    {
                        int remove = Convert.ToInt32(Console.ReadLine());
                        l.RemoveAt(remove);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Norādītais indekss sarakstā nav pieejams!");
                    }
                }
                else if (ievade == "3")
                {
                    Console.WriteLine("Paldies, ka lietojā šo programmu!");
                    break;
                }
                else
                {
                    Console.WriteLine("Jūs esat ievadījuši nepareizu simbolu, lūdzu, ievadiet no 1 līdz 3!");
                    Console.WriteLine();
                }

                if (l.Count == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Saraksts ir tukšs!");
                    Console.WriteLine("Vai vēlaties programmu sākt no jauna? Ja vēlaties, tad uzrakstiet Y");
                    String ievadeBeigt = Console.ReadLine();
                    ievadeBeigt.ToLower();
                    if (ievadeBeigt == "y")
                    {
                        List2();
                    }
                    else
                    {
                        Console.WriteLine("Paldies, ka lietojā šo programmu!");
                        break;
                    }
                }
            }
        
        }
        
    }
       
}

