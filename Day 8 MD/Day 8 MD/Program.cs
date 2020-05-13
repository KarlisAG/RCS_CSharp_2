﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_8_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5};
            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6};
            List<int> list3 = new List<int>() { 1, 2, 3, 4, 5};

            Console.WriteLine(Check(list1, list2));
            ArraySwap();
        }

        public static bool Check(List<int> a, List<int> b)
        {
            //if (a == b)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return a.SequenceEqual(b);
        }

        public static void ArraySwap()
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            Console.WriteLine("Ievadiet 5 veselus skaitlus!");
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    array1[i] = input;
                }
                catch
                {
                    Console.WriteLine("Nepareiza ievade, meginiet velreiz!");
                    array1[i] = Fail();
                }

                
            }
            int y = 4;
            foreach (int aa in array1)
            {
                array2[y] = aa;
                y--;
            }

            Array1Print(array1);
            Array2Print(array2);
        }

        public static void Array1Print(int[] a)
        {
            Console.WriteLine("Array1: ");
            foreach (var aa in a)
            {
                Console.Write(aa + ", ");
            }
        }
        public static void Array2Print(int[] a)
        {
            Console.WriteLine();
            Console.WriteLine("Array2: ");
            foreach (var aa in a)
            {
                Console.Write(aa + ", ");
            }
        }

        public static int Fail()
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade, meginiet velreiz!");
                return Fail();
            }
        }
    }
}
/*2) Uztaisīt boolean metodi, kas atgriež vai divi saraksti, kas padoti iekšā kā paramatri ir vienādi.

3) Uztaisīt metodi, kur cilvēks ievada 5 masīva vērtības. (int)
Apgriezt masīvu otrādi.

Piemērs- cilvēks ievada 1, 2, 3, 4, 99. Tās ir pirmā masīva vērtības.
Otrā masīva vērtības būs- 99, 4, 3, 2, 1

*uztaisīt metodi, kas izvada masīva vērtības (padodot masīvu kā parametru). Testēt gan ar pirmo, gan otro masīvu.
*/