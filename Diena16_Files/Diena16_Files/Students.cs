﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Diena16_Files
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
            setCourse(course);
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setCourse(int course)
        {
            if (course > 3)
            {
                course = 3;
            }

            if (course < 1)
            {
                course = 1;
            }

            this.course = course;
        }

        public void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(course);
        }

        public String getName()
        {
            return name;
        }

        public String getSurname()
        {
            return surname;
        }

        public int getCourse()
        {
            return course;
        }
    }
}
