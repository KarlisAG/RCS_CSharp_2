using System;
using System.Collections.Generic;
using System.Text;

namespace Diena6__Classes_Klases
{
    class Tasks
    {
        public static void Task1(int a)
        {
            String zvaigzne = "";
            for (int i = 0; i < a; i++)
            {
                zvaigzne = zvaigzne + "*";
                Console.WriteLine(zvaigzne);
            }
        }
    }
}
