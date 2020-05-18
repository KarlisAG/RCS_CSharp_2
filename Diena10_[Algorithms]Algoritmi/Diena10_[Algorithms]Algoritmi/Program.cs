using System;

namespace Diena10__Algorithms_Algoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort();

        }

        public static void GnomeSort() 
        { 

        }


        public static void BubbleSort()
        {
            Random rnd = new Random();
            int[] rndArray = new int[10];

            Console.WriteLine("-----Pirms------");

            for (int i = 0; i < rndArray.Length; i++)
            {
                rndArray[i] = rnd.Next(41);//janem 1 vairak, jo ir neieskaitot to skaitli
                Console.Write(rndArray[i] + " ");
            }

            for (int i = 0; i < rndArray.Length - 1; i++)
            {
                for (int j = 0; j < rndArray.Length - i - 1; j++)
                {
                    if (rndArray[j] > rndArray[j + 1])
                    {
                        int temp = rndArray[j];
                        rndArray[j] = rndArray[j + 1];
                        rndArray[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----Pēc------");

            for (int i = 0; i < rndArray.Length; i++)
            {
                Console.Write(rndArray[i] + " ");
            }
        }
    }
}
