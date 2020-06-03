using System;
using System.Collections.Generic;
using System.Text;

namespace Diena16_Files
{
    class Task1
    {
        public static void Run()
        {
            String studentInfo = "Juris,Abolins,3";


            //Ar String.Split parveidot uz 3 vertibam
            //Un taad no siem tad no siem 3 string uztaisit jaunu studenta klases objektu student1
            String[] students = studentInfo.Split(',');
            int studentCourse = Convert.ToInt32(students[2]);

            Students st = new Students(students[0], students[1], studentCourse);
        }
    }
}
