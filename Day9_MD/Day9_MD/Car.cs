using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_MD
{
    class Car
    {
        private String color;
        String brand;
        int doors;

        public Car(String color, String brand, int doors)
        {
            this.color = color;
            this.brand = brand;
            this.doors = doors;
        }

        public void Menu()
        {
            List<Car> car = new List<Car>();
            Console.WriteLine("Sveiki! Ievadiet, ludzu, 5 dazadus auto parametrus");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet auto krasu");
                String inColor = Console.ReadLine();
                Console.WriteLine("Ievadiet auto brandu");
                String inBrand = Console.ReadLine();
                Console.WriteLine("Ievadiet auto durvju skaitu");
                int inDoors = Convert.ToInt32(Console.ReadLine());
                car.Add(new Car(inColor, inBrand, inDoors));

            }


            Console.WriteLine("Vai Jus velaties: ");
            Console.WriteLine("1 - apskatit auto sarakstu");
            Console.WriteLine("2 - pievienot auto sarakstam");
            Console.WriteLine("3 - meklet auto saraksta");
            Console.WriteLine("0 - iziet no programmas");

            String choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Print();
                    break;
                case "2":
                    AddCar();
                    break;
                case "3":
                    Search();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Nepareiza ievade!");
                    break;
            }
        }

        public void Print()
        {
            int i = 0;

        }

        public void AddCar()
        {

        }

        public void Search()
        {

        }
    }
}
