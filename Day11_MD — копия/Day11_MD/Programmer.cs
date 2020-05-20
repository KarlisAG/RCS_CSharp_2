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

        public void Work() //ar new parāda, ka tas tā ir domāts un ka vnk nekļūdījies; var arī bez NEW, errors nebūs un viss strādās ok
        {
            Console.WriteLine("Programmer is programming");
        }
        public override void Print()
        {
            Console.WriteLine(name + " " + language);
        }
    }
}
