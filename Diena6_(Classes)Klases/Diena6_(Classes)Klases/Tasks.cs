using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Diena6__Classes_Klases
{
    class Tasks
    {
        private static int a = 0;
        private static int b = 0;

        public static void Task1(int a)
        {
            String zvaigzne = "";
            for (int i = 0; i < a; i++)
            {
                zvaigzne = zvaigzne + "*";
                Console.WriteLine(zvaigzne);
            }
        }
        public static int VērtībaA(int A)
        {
            Tasks.a = A;
            //Console.WriteLine("a ir " + Tasks.a);
            return Tasks.a;
        }
        public static int VērtībaB(int B)
        {
            Tasks.b = B;
            //Console.WriteLine("b ir " + Tasks.b);
            return Tasks.b;
        }
    }
}
