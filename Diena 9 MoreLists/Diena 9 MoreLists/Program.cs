using System;
using System.Collections.Generic;

namespace Diena_9_MoreLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();
            

            
        }

        static void Sample()
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Janis", "Berzins", 1));
            listOfStudents.Add(new Student("Juris", "Abele", 2));
            listOfStudents.Add(new Student("Kristaps", "Kalejs", 3));

            for(int i = 0; i < listOfStudents.Count; i++)
            {
                listOfStudents[i].print();
                listOfStudents[i].setCourse(1);//visiem uzliek 1. kursu
            }

            foreach (Student st in listOfStudents)
            {
                st.print();
            }
        }
        static void Example1()
        {
            List<Student> listOfStudents = new List<Student>();
            String ievade = "";

            while (ievade != "0")
            {
                Console.WriteLine("Sveiki! Ko Jus velaties izdarit?");
                Console.WriteLine("1 - izvadit studentu sarakstu");
                Console.WriteLine("2 - pievienot jaunu studentu saraksta");
                Console.WriteLine("0 - iziet no programmas");
                ievade = Console.ReadLine();

                switch(ievade)
                {
                    case "1":
                        foreach(Student st in listOfStudents)
                        {
                            st.print();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ievadiet studenta vardu!");
                        String inName = Console.ReadLine();
                        Console.WriteLine("Ievadiet studenta uzvardu!");
                        String inSurname = Console.ReadLine();
                        Console.WriteLine("Ievadiet studenta kursu!");
                        int inCourse = Convert.ToInt32(Console.ReadLine());
                        listOfStudents.Add(new Student (inName, inSurname, inCourse));
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Ievades kluda!");
                        break;
                }
            }

        }
    }
}
