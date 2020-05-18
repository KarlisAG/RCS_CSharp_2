using System;
using System.Diagnostics;

namespace Day10_MD
{
    class Program
    {
        static int[] arr = new int[10000];
        static Stopwatch stopWatch = new Stopwatch();
        static Stopwatch watch = new Stopwatch();
        static int[] arr2;

        static void Main(string[] args)
        {
            Random();
            Console.WriteLine("Sakas bubble sort");
            BubbleSort();
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
        }
        public static void BubbleSort()
        {
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
            stopWatch.Stop();
            Console.WriteLine("Aizņemtais laiks ciklam: " + stopWatch.ElapsedMilliseconds + " milisekundes");
        }
        public static void GnomeSort()
        {
            stopWatch.Reset();
            stopWatch.Start();

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

            stopWatch.Stop();
            Console.WriteLine("Aizņemtais laiks ciklam: " + stopWatch.ElapsedMilliseconds + " milisekundes");
        }
    }
}

