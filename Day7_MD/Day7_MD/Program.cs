using System;
using System.Collections.Generic;

namespace Day7_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            MD();
        }

        static void MD()
        {
            Random random = new Random();

            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(100));
            }

            String choice = "";
            while (choice != "0")
            {
                Console.WriteLine("1 - izvadīt sarakstu");
                Console.WriteLine("2 - dzēst");
                Console.WriteLine("0 - iziet");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        foreach (int a in numbers)
                        {
                            Console.WriteLine(a);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Kuru dzēst?");
                        int toDelete = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            numbers.RemoveAt(toDelete);
                        }
                        catch(ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Ievadītais indekss nav atrodams sarakstā!");
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("nepareiza ievade!");
                        break;
                }

                if(numbers.Count == 0)
                {
                    Console.WriteLine("Saraksts ir tukšs!");
                    break;
                }
            }
        

        }

    }
}


