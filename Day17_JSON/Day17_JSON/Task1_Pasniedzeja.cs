using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace Day17_JSON
{
    class Task1_Pasniedzeja
    {
        public static List<Student> GetStudentList(String filename)
        {
            try
            {
                StreamReader reader = new StreamReader(filename);
                String line = reader.ReadLine();
                String json = "";
                while (line != null)
                {
                    json += line;

                    line = reader.ReadLine();
                }
                reader.Close();

                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
                return students;
            }
            catch
            {
                return null;
            }
            
        }

        public static void WriteStudentList(List<Student> students)
        {
            String json = JsonConvert.SerializeObject(students);
            try
            {
                StreamWriter sw = new StreamWriter("Test.json");
                sw.Write(json);
                sw.Close();//mes ielasijam visu, kad ir zinams, ka viss iet zem iviena objektu lista, bet ko darit ja pirms un pec ta ir citas vertibas piemeram cits lsits, vnk strngi, int utt; ka tad to visu ielasit?
            }
            catch
            {
                Console.WriteLine("Fail!");
            }
        }
    }
}
