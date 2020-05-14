using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_MD
{
    class Car
    {
        private String color;
        private String brand;
        private int doors;
        private List<Car> car = new List<Car>();

        public Car(String color, String brand, int doors)
        {
            this.color = color;
            this.brand = brand;
            this.doors = doors;
        }

        public Car()
        {

        }

        public void Start()
        {
            Console.WriteLine("Sveiki! Ievadiet, ludzu, 5 dazadus auto parametrus");
            AddCar(5);
            Menu();
        }
        public void Menu()
        {

            Console.WriteLine("Vai Jus velaties: ");
            Console.WriteLine("1 - apskatit auto sarakstu");
            Console.WriteLine("2 - pievienot auto sarakstam");
            Console.WriteLine("3 - meklet auto saraksta");
            Console.WriteLine("0 - iziet no programmas");

            String choice = "";

            while (choice != "0")
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        foreach (Car c in car)
                        {
                            c.Print();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Cik jaunas masinas Jus velaties pievienot?");
                        try 
                        { 
                            int amountCar = Convert.ToInt32(Console.ReadLine()); 
                            AddCar(amountCar);
                        }
                        catch
                        {
                            Console.WriteLine("Nepareiza ievade, ludzu, ievatiet ciparu!");
                            AddCar(WrongInputCatch());
                        }
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
        }

        public void Print()
        {
                Console.WriteLine();
                Console.Write("krasa: " + color + ", ");
                Console.Write("marka: " + brand + ", ");
                Console.Write("durvju skaits: " + doors);
                Console.WriteLine();
        }

        public void AddCar(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Ievadiet auto krasu");
                String inColor = Console.ReadLine();
                Console.WriteLine("Ievadiet auto brandu");
                String inBrand = Console.ReadLine();
                Console.WriteLine("Ievadiet auto durvju skaitu");
                try
                {
                    int inDoors = Convert.ToInt32(Console.ReadLine());
                    car.Add(new Car(inColor, inBrand, inDoors));
                }
                catch
                {
                    Console.WriteLine("Nepareiza ievade, ludzu, ievatiet ciparu!");
                    car.Add(new Car(inColor, inBrand, WrongInputCatch()));
                }
            }
        }
        public void Search()
        {
            Console.WriteLine("Pec kadiem parametriem jus velaties mekle?");
            Console.WriteLine("1 - auto krasas");
            Console.WriteLine("2 - auto markas");
            Console.WriteLine("3 - auto durvju skaita");
            Console.WriteLine("0 - lai atgrieztos Menu");

            String choice = "";
            while (choice != "0")
            {
                switch (choice)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade!");
                        Console.WriteLine();
                        break;
                }
            }
        }

        public int WrongInputCatch()
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade, ludzu, ievatiet ciparu!");
                return WrongInputCatch();
            }
        }
    }
}
