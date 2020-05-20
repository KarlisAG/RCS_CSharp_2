using System;
using System.Collections.Generic;
using System.Data;

namespace Day11_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer("janis", 22, 2000, "c#");
            p.Work();

            Manager m = new Manager("Martins", 27, 2200, 2);
            m.Work();

            DatabasePRO d = new DatabasePRO("Oskars", 25, 1500, "aa");
            d.Work();
        }

        public void MD()
        {
            List<Employee> e = new List<Employee>();
            Console.WriteLine("Sveiki! Ievadiet, ludzu, datus par savas komandas dalibniekiem");
            Console.WriteLine();
            Console.WriteLine("Menedzers");
            e.Add(new Manager(Name(), Age(), MonthlySalary(), YearsOfExperience()));
            Console.WriteLine();
            Console.WriteLine("1. programmetajs");
            e.Add(new Programmer(Name(), Age(), MonthlySalary(), Language()));
            Console.WriteLine();
            Console.WriteLine("2. programmetajs");
            e.Add(new Programmer(Name(), Age(), MonthlySalary(), Language()));
            Console.WriteLine();
            Console.WriteLine("datubazu eksperts");
            e.Add(new DatabasePRO(Name(), Age(), MonthlySalary(), DatabaseTool()));

            //foreach (Manager a in e)
            //{
            //    a.Print();
            //}
            foreach (Employee em in e)
            {
                if (em is Manager m)
                {
                    //tad šādi var čekot kas ir tajā un var daīt konkrēto darbību
                }
                else
                {
                    if (em is Programmer)//ar is tu pārbaudi nevis vērtību bet tipu!!
                    {

                    }
                    else
                    {
                        DatabasePRO d = em as DatabasePRO;//tips e selektots ka databasepro objects
                    }
                }
            }
            //foreach (Programmer a in e)
            //{
            //    a.Print();
            //}

            //foreach (DatabasePRO a in e)
            //{
            //    a.Print();
            //}

            Programmer p1 = GetProgrammer();
            Programmer p2 = GetProgrammer();
        }

        public static String Name()
        {
            Console.WriteLine("Ievadiet vardu");
            String name = Console.ReadLine();
            return name;
        }

        public static int Age()
        {
            Console.WriteLine("Ievadiet vecumu");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        public static int MonthlySalary()
        {
            Console.WriteLine("Ievadiet videjo menesa algu");
            int monthlySalary = Convert.ToInt32(Console.ReadLine());
            return monthlySalary;
        }

        public static String Language()
        {
            Console.WriteLine("Ievadiet programmesanas valodu");
            String language = Console.ReadLine();
            return language;
        }

        public static int YearsOfExperience()
        {
            Console.WriteLine("Ievadiet nostradato gadu daudzumu");
            int yearsOfExperience = Convert.ToInt32(Console.ReadLine());
            return yearsOfExperience;
        }

        public static String DatabaseTool()
        {
            Console.WriteLine("Ievadiet datubazu riku");
            String databaseTool = Console.ReadLine();
            return databaseTool;
        }

        static Programmer GetProgrammer()//pasniedzeja
        {
            Console.WriteLine("ievadiet vardu");
            String name = Console.ReadLine();

            Console.WriteLine("Ievadiet vecumu");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadiet videjo menesa algu");
            int monthlySalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadiet programmesanas valodu");
            String language = Console.ReadLine();

            Programmer pr = new Programmer(name, age, monthlySalary, language);
            return pr;
        }

    }
}
