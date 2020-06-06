using System;
using Newtonsoft.Json;
using System.Collections.Generic;//lai strādātu ar listiem
using System.IO;

namespace Day17_JSON
{
    class Program
    {
        static void Main(string[] args)
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
                StreamWriter sw = new StreamWriter(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Day 17\Test.json");
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
