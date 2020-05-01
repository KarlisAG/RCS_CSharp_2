using System;

namespace Day5_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            FridayTask3Extra();
        }

        static void FridayTask3Extra()
        {
            int[] mas = new int[10];
            Random random = new Random();
            int cits = 0;
            for (int i = 0; i < 10; i++)
            {
                mas[i] = random.Next(1, 11);
                //Console.Write(mas[i] + " ");
            }
            Console.WriteLine("Ievadiet skaitli, ko meklēt");
            int sk = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (sk == mas[i])
                {
                    Console.WriteLine("Indekss " + i);
                }
                else
                {
                    cits++;
                }
                if (cits == 10)
                {
                    Console.Write("Jūsu ievadītais cipars nav atrodams masīvā!");
                }
            }
        }
    }
}
