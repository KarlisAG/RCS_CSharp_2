using System;
using Newtonsoft.Json;
using System.Collections.Generic;//lai strādātu ar listiem
using System.IO;
using System.ComponentModel;

namespace Day17_JSON
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //JSONSample();
            //Task1 t1 = new Task1();
            //t1.Task();

            //pasniedzjea \|
            String filename = "Test.json";
            List<Student> students = Task1_Pasniedzeja.GetStudentList(filename);

            if(students == null)
            {
                students = new List<Student>();//ja nav saraksta, tad incialize tuksu sarakstu
                //TODO create new file
            }

            while (true)
            {
                Console.WriteLine("1 - add");
                Console.WriteLine("2 - display");
                Console.WriteLine("0 - exit");

                String choice = Console.ReadLine();

                if (choice == "0")//bezgaligaja cikla swith nelieto, jo switcha break izies tikai no switch, bet ja ar if tad break iziet no while; ar return var - tad iziet no metodes
                {
                    break;
                }
                else if (choice == "1") 
                {
                    Add(students);
                }
                else if (choice == "2")
                {
                    foreach(Student st in students)
                    {
                        st.print();
                    }
                }
            }

        }

        private static void Add(List<Student> students)
        {
            int count = students.Count + 1;

            students.Add(new Student(("Dummy" + count), "Dummyson", 1));

            Task1_Pasniedzeja.WriteStudentList(students);
        }

        public static void JSONSample()
        {
            List<Car> cars = new List<Car>();

            Car c = new Car("BMW", "M3", 2);
            cars.Add(c);
            cars.Add(new Car("Opel", "Astra", 4));
            cars.Add(new Car("Audi", "A4", 4));

            //JSON ir tie paši simboli
            String json = JsonConvert.SerializeObject(cars, Formatting.Indented);//ar formating.inteded noformate smukak, bet tas rup tikai cilvekam, datoram pofig
            //serializēt nozīmē uztaisīt to tiesi par json
            //json = "{ \"brand\": \"BMW\", \"model\":\"M3\", \"doorCount\":2, \"color\":\"red\"}";//ar b.brand viņš atradīs, ko vajag un izvadīs pat ja visi pārējie nav; bet ja nav brand, tad neko neizvada (Console.Writeline)
            Console.WriteLine(json);
            Write(json);
            //Car b = JsonConvert.DeserializeObject<Car>(json);//ar <> pasaka uz kuru objektu mēģina pārveidot

            //Console.WriteLine(b.brand);

            List<Car> cars2 = JsonConvert.DeserializeObject<List<Car>>(json);
            Console.WriteLine(cars2[0].brand + " " + cars2[1].model);
        }
        public static void Write(String json)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Day_17\Test.json");
                sw.Write(json);
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Fail!");
            }
        }
    }
}
