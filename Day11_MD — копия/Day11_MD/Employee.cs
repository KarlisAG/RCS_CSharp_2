using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    abstract class Employee
    {
        protected String name;
        protected int age;
        protected int monthlySalary;

         public virtual void Work()
         {
            Console.WriteLine("Employee is working");
         }

        public void Test()//caur šo var tad dabūt dažādas vērtības; visi piesauc vienu, bet rezultāti mainīsies no apakšklasēm
        {
            Print();
            Console.WriteLine("Test done");
        }

        public abstract void Print();//nav jātaisa implementācija; nav jāsaka ko darīt// implementācijai ir jābūt katrā apakšklasē
        //tad visām apakšklasēm ir jābūt Print()
    }

    
}
