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

        public override void Work()//ar so strada ta pat jeb ir same rezultats, bet darbiba ir labaka it ka
        {
            Console.WriteLine("Manager is managing");
        }
        public override void Print()
        {
            Console.WriteLine(name + " " + yearsOfExperience);
            //Console.WriteLine(name + ", " + age + ", " + monthlySalary + ", " + yearsOfExperience);
        }
    }
}

