using System;
using System.Collections.Generic;
using System.Text;

namespace Diena16_Files
{
    class Task3
    {
        Students st;
        List<Students> stList = new List<Students>();
        public void Menu() 
        {
            String ievade = "";
            while (ievade != "0")
            {
                Console.WriteLine("Sveiki! Ko Jus velaties darit?");
                Console.WriteLine("1 - pievienot sarakstam studentu");
                Console.WriteLine("2 - apskatit sarakstu");
                Console.WriteLine("3 - saglabat sarkastu faila");
                Console.WriteLine("0 - iziet no programmas");

                switch (ievade)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Print();
                        break;
                    case "3":
                        Save();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Ievades kluda!");
                        break;
                }
            }
        }

        public void Add()
        {
            Console.WriteLine("Ievadiet studenta vardu!");
            String name = Console.ReadLine();
            Console.WriteLine("Ievadiet studenta uzvardu!");
            String surname = Console.ReadLine();
            Console.WriteLine("Ievadiet studenta kursu!");
            int course = Convert.ToInt32(Console.ReadLine());

            st = new Students(name, surname, course);
        }

        public void Print()
        {
            
            st.print();
            
        }

        public void Save()
        {

        }
    }
}
