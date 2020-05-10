using System;
using System.Collections.Generic;
using System.Text;

namespace Day7__Objects_Objekti
{
    class Students
    {
        private String name;
        private String surname;
        private int course;

        public Students(String name, String surname, int course)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;
        }

        public void Print()
        {
            Console.WriteLine(name + " " + surname + " " + course);
        }
    }
}
