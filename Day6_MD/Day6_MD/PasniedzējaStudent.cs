using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_MD
{
    class PasniedzējaStudent
    {
        private static String name;
        private static String surname;
        private static int course;


        public static void setName(String name)
        {
            PasniedzējaStudent.name = name;//jāuzraksta no kurinees ņem, savādāk tas prioretizēs lokālo

        }

        public static void setSurname(String surname)
        {
            PasniedzējaStudent.surname = surname;
        }

        public static void setCourse(int course)
        {
            if(course > 3)
            {
                course = 3;
            }

            if(course < 1)
            {
                course = 1;
            }

            PasniedzējaStudent.course = course;
        }

        public static void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(course);
        }

        public static String getName()
        {
            return name;
        }

        public static String getSurname()
        {
            return surname;
        }

        public static int getCourse()
        {
            return course;
        }
    }
}
