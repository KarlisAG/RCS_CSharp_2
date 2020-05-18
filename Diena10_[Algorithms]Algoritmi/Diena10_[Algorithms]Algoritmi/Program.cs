using System;
using System.Diagnostics;

namespace Diena10__Algorithms_Algoritmi
{
    class Program
    {
        static int[] arr = new int[10];
        static int[] arr2 = new int[10];

        static void Main(string[] args)
        {
            Random();
            Console.WriteLine("Bubble sort");
            Console.WriteLine();
            BubbleSort();
            Random2();
            Console.WriteLine();
            Console.WriteLine("Gnome sort");
            Console.WriteLine();
            GnomeSort();
        }
        public static void Random()
        {
            Random random = new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(41);
            }
        }
        public static void Random2()
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = random.Next(41);
            }
        }

        public static void GnomeSort() 
        {
            Console.WriteLine("-----Pirms-----");
            PrintArray(arr2);
            int g = 0;
            while (g < arr2.Length) 
            {
                if (g == 0)
                {
                    g++;
                }
                if (arr2[g] >= arr2[g - 1])
                {
                    g++;
                }
                else
                {
                    int temp = arr2[g];
                    arr2[g] = arr2[g - 1];
                    arr2[g - 1] = temp;
                    g--;
                }
            }

            Console.WriteLine();
            Console.WriteLine("-----Pēc-----");
            PrintArray(arr2);
        }


        public static void BubbleSort()
        {
            Console.WriteLine("-----Pirms------");
            PrintArray(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----Pēc------");
            PrintArray(arr);
        }


        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
