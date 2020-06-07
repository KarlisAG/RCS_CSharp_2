using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace Day17_JSON
{
    class Task1
    {
        public void Task()
        {
            List<Student> st = new List<Student>();

            Student s = new Student("Karlis", "Gribulis", 3);
            st.Add(s);
            st.Add(new Student("Marija", "Soldatenko", 2));


            String json = JsonConvert.SerializeObject(st, Formatting.Indented);//serializējot šiem paramatriem ir jābūt publiskiem, ne privātiem
            Console.WriteLine(json);
            Write(json);
            Read();
            //st.Add(new Student("Peteris", "Ozols", 1));
        }
        public static void Write(String json)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Day_17\Students.json");
                sw.Write(json);
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Fail!");
            }
        }
        public static void Read()
        {

            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Day_17\Students.json");

                String line = sr.ReadLine();
                while(line != null)
                {
                    line += sr.ReadLine();
                }
                List<Student> st = JsonConvert.DeserializeObject<List<Student>>(line);
                Console.WriteLine(st);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Kļūda!" + e.Message);
            }
            
        }
    }
}
