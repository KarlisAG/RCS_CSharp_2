using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Diena6__Classes_Klases
{
    class Tasks
    {
        private static int a = 0;
        private static int b = 0;

        public static void setA(int localA)//pasniedzēja variants
        {
            if(localA < 0)
            {
                localA = 0; //šādi pieķert negatīvo vērtību un piešķirt kko citu -> izķer kādas lietas kodā
            }
            a = localA;//vajag lai viss trādā modulāri..? lai viena daļa neietekmē kko citu; ja ir setA, tad lai ir tikai tikai setA
            //šajā gadījumā ja nomaina setA, tad tas nemaina getA
        }
        public static void setB(int localB)
        {
            b = localB;
        }

        public static int getA()
        {
            return a;
        }

        public static int getB()
        {
            return b;
        }
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
