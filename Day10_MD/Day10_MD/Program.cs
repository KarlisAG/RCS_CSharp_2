using System;
using System.Diagnostics;

namespace Day10_MD
{
    class Program
    {
        static int[] arr = new int[10000];
        static Stopwatch stopWatch = new Stopwatch();
        static int[] arr2;

        static void Main(string[] args)
        {
            Random();
            Console.WriteLine("Sakas bubble sort");
            //BubbleSort();
            Console.WriteLine("Sakas gnome sort");
            GnomeSort();
        }
        public static void setArr2(int[] a)
        {
            arr2 = a;
        }

        public static int[] getArr2(int[] a)
        {
            return a;
        }
        public static void Random()
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100000);
            }
            setArr2(arr);

            //PrintArray(arr);

        }

        public static void GnomeSort()
        {
            Stopwatch watch = stopWatch;

            //PrintArray(arr2);
            //Console.WriteLine("-----Pirms-----");
            //PrintArray(arr);
            watch.Start();

            int g = 0;
            //Console.WriteLine("Garums: " + arr2.Length);
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

            //Console.WriteLine();
            //Console.WriteLine("-----Pēc-----");
            //PrintArray(arr2);

            watch.Stop();
            Console.WriteLine("Aizņemtais laiks ciklam: " + watch.ElapsedMilliseconds + " milisekundes");
        }


        public static void BubbleSort()
        {
            //Console.WriteLine("-----Pirms------");
            //PrintArray(arr);

            stopWatch.Start();

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
            //Console.WriteLine();
            //Console.WriteLine("-----Pēc------");
            //PrintArray(arr);

            stopWatch.Stop();

            Console.WriteLine("Aizņemtais laiks ciklam: " + stopWatch.ElapsedMilliseconds + " milisekundes");
            stopWatch.Reset();

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

