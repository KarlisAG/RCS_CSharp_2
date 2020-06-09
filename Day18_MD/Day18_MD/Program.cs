using System;
using System.Net;
using Newtonsoft.Json;

namespace Day18_MD
{
    class Program
    {
        static void Main(string[] args)
        {

            String url = "https://my-json-server.typicode.com/KarlisAG/FakeRest/data";
            
            WebClient client = new WebClient();

            String response = client.DownloadString(url);

            Console.WriteLine(response);

            //TempData rec = JsonConvert.DeserializeObject<TempData>(response);

            //if (rec.status == "success")
            //{
            //    foreach (Student s in rec.st)
            //    {
            //        Console.WriteLine(s.name + " " + s.getSurname() + " " + s.getCourse());
            //    }
            //}
        }
    }
}
