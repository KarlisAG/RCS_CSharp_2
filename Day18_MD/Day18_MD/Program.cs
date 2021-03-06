﻿using System;
using System.Collections.Generic;
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
            List<Student> sts = JsonConvert.DeserializeObject<List<Student>>(response);
            //List<Student> stList = (List<Student>)JsonConvert.DeserializeObject(response);
            //TempData lst = JsonConvert.DeserializeObject<TempData>(response);
            foreach (Student s in sts)
            {
                Console.WriteLine(s.name + " " + s.surname + " " + s.course);
            }
        }
    }
}
