using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_MD
{
    class Menu
    {
        DBConnection con = new DBConnection();

        public void Start()
        {
            if (con.Connect())
            {
                Console.WriteLine("Savienojums ir veiksmigs!");

                String choice = "";
                while (choice != "0")
                {
                    Console.WriteLine();
                    Console.WriteLine("Sveicinati Menu! Izvelaties, ko Jus velaties darit!");
                    Console.WriteLine("1 - apskatit datubazes sarakstu");
                    Console.WriteLine("2 - pievienot studentu datubazei");
                    Console.WriteLine("3 - izdzest studentu no datubazes");
                    Console.WriteLine("0 - iziet no programmas");

                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            con.GetEmployees();
                            break;
                        case "2":
                            con.AddStudent();
                            break;
                        case "3":
                            con.DeleteStudent();
                            break;
                        case "0":
                            break;
                        default:
                            Console.WriteLine("Nepareiza ievade!");
                            break;
                    }
                }
            
            }
            else
            {
                Console.WriteLine("Savienojums ir neveiksmigs, parbaudiet kludas koda!");
            }
        }
    }
}
