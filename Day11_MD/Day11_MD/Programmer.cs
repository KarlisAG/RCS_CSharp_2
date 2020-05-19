using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Programmer : Employee
    {
        private String language;

        public Programmer(String name, int age, int monthlySalary, String language)
        {
            this.name = name;
            this.age = age;
            this.monthlySalary = monthlySalary;
            this.language = language;
        }

        public void Print()
        {
            Console.WriteLine(name + ", " + age + ", " + monthlySalary + ", " + language);
        }
    }
}
