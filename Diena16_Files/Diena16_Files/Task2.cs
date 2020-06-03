using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Diena16_Files
{
    class Task2
    {
        public static void Run()
        {
            String studentInfo = "Juris,Abolins,3";

            String[] students = studentInfo.Split(',');

            //String StudentsAgain = "";
            //for (int i = 0; i < students.Length; i++)
            //{
            //    StudentsAgain = StudentsAgain + students[i] + ",";
            //}
            //var uztaisit ka string pedejo komatu ignore;; cikla parbaudit ar if vai sis ir pedeja
            String stTest = String.Join("," , students);
            Console.WriteLine(stTest);

            StreamWriter sw = new StreamWriter("Students.txt");
            //sw.WriteLine("hello");
            sw.Write(stTest);
            sw.Close();//ja nav aiztaisīt, tad tas visu atmina tur un neko ta ari neieraksta
        }

    }
}
