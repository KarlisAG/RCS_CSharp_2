using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class DatabasePRO : Employee
    {
        private String databaseTool;

        public DatabasePRO(String name, int age, int monthlySalary, String databaseTool)
        {
            this.name = name;
            this.age = age;
            this.monthlySalary = monthlySalary;
            this.databaseTool = databaseTool;
        }
        public void Print()
        {
            Console.WriteLine(name + ", " + age + ", " + monthlySalary + ", " + databaseTool);
        }
    }
}

