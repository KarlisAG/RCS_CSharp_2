using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day9_MD
{
    class Car
    {
        private String color { get; set; }
        private String brand { get; set; }
        private int doors { get; set; }
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
            //AddCar(5);
            Menu();
        }
        public void Menu()
        {
            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine("Vai Jus velaties: ");
                Console.WriteLine("1 - apskatit auto sarakstu");
                Console.WriteLine("2 - pievienot auto sarakstam");
                Console.WriteLine("3 - meklet auto saraksta");
                Console.WriteLine("0 - iziet no programmas");
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
                            Console.WriteLine("Nepareiza ievade, ludzu, ievadiet ciparu!");
                            Console.WriteLine();
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
                        Console.WriteLine();
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
                    Console.WriteLine("Nepareiza ievade, ludzu, ievadiet ciparu!");
                    Console.WriteLine();
                    car.Add(new Car(inColor, inBrand, WrongInputCatch()));
                }
            }
        }
        public void Search()
        {
            String search;
            Console.WriteLine();
            Console.WriteLine("Pec kadiem parametriem jus velaties mekle?");
            Console.WriteLine("1 - auto krasas");
            Console.WriteLine("2 - auto markas");
            Console.WriteLine("3 - auto durvju skaita");
            Console.WriteLine("4 - lai atgrieztos Menu");
            Console.WriteLine("0 - lai izietu no programmas");

            String choice = "";
            while (choice != "0")
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        search = Console.ReadLine();
                        foreach(var a in car)
                        {
                            Console.WriteLine(a);
                        }
                        for (int i = 0; i < car.Count; i++)
                        {
                            //if (car.FirstOrDefault(x => x.color = search))
                            //{
                            //    Console.WriteLine("Tada krasa ir " + i + 1 + ". masinai");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Tads rezultats nav atrodams!");
                            //    Console.WriteLine();
                            //    break;
                            //}
                        }
                        break;
                    case "2":
                        search = Console.ReadLine();
                        for (int i = 0; i < car.Count; i++)
                        {
                            if (car.Contains(new Car { brand = search }))
                            {
                                Console.WriteLine("Tada marka ir " + i + 1 + ". masinai");
                            }
                            else
                            {
                                Console.WriteLine("Tads rezultats nav atrodams!");
                                Console.WriteLine();
                                break;
                            }
                        }
                        break;
                    case "3":
                        try 
                        { 
                            int searchNum = Convert.ToInt32(Console.ReadLine()); 
                            for (int i = 0; i < car.Count; i++)
                            {
                                if (car.Contains(new Car { doors = searchNum }))
                                { 
                                    Console.WriteLine("Tads durvju skaits ir " + i + 1 + ". masinai");
                                }
                                else
                                {
                                    Console.WriteLine("Tads rezultats nav atrodams!");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine();
                            Console.WriteLine("Nepareiza ievade, ludzu, ievadiet ciparu!");
                            int newSearchNum = WrongInputCatch();
                            for (int i = 0; i < car.Count; i++)
                            {
                                if (car.Contains(new Car { doors = newSearchNum }))
                                {
                                    Console.WriteLine("Tads durvju skaits ir " + i + 1 + ". masinai");
                                }
                                else
                                {
                                    Console.WriteLine("Tads rezultats nav atrodams!");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                            
                        }
                        break;
                    case "4":
                        Menu();
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
                Console.WriteLine("Nepareiza ievade, ludzu, ievadiet ciparu!");
                Console.WriteLine();
                return WrongInputCatch();
            }
        }
    }
}
