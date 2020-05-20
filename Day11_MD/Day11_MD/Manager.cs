using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Manager : Employee
    {
        private int yearsOfExperience;

        public Manager(String name, int age, int monthlySalary, int yearsOfExperience)
        {
            this.name = name;
            this.age = age;
            this.monthlySalary = monthlySalary;
            this.yearsOfExperience = yearsOfExperience;
        }
        public void Print()
        {
            Console.WriteLine(name + ", " + age + ", " + monthlySalary + ", " + yearsOfExperience);
        }
    }
}

