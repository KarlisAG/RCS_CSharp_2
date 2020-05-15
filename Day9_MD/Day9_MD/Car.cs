using System;
using System.Collections.Generic;
using System.Linq;
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
            //so uztaisiju jo savadak nemaceju uztaisit objektu, kas saktu sis klases darbibu, ka to vareja izdarit?
        }

        public void Start()
        {
            Console.WriteLine("Sveiki! Ievadiet, ludzu, 5 dazadus auto parametrus");
            AddCar(5);
            Menu();
        }
        public void Menu()
        {
            String choice = "";
            //int times = 0;
            while (choice != "0")
            {
                Console.WriteLine();
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
                            c.Print();//ka uztaisit, lai izprintejot parada, ka 0., 1. .. auto krasas utt ir...; vienkarsi gribu, lai ne tikai izprinte parametrus, bet ari norada ta auto indeksu, ka to dabut?
                            //times++; ---> tas nesanaca ---> //zinu ka vareju c.Print() un rezultats butu tads pats, bet gribeju lai printesana rada, kuras masinas indeksam ir konkretas ipasibas
                        }
                        
                        //times = 0;
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

        public void Print(/*int times*/)
        {
            //for (int i = 0; i < times; i++)//kapec ja ir sis cikls, tad vins nesaglabaja jaunas izmainas attiecigajos parametros? tas piefikseja, ka ir X auto skaits, bet vinu parametros sagalbaja tuksumus, jo tas ir arpus foreach un vins nesaprot, ka izmainas notiek sarakstam..?
            //{
                Console.WriteLine();
                //Console.WriteLine(i + ". Masinas ");
                Console.Write("krasa: " + color + ", ");
                Console.Write("marka: " + brand + ", ");
                Console.Write("durvju skaits: " + doors);
                Console.WriteLine();
            //}
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
            String choice = "";
            int i = 0;
            bool found = false;
            while (choice != "0")
            {
                Console.WriteLine();
                Console.WriteLine("Pec kadiem parametriem jus velaties meklet?");
                Console.WriteLine("1 - auto krasas");
                Console.WriteLine("2 - auto markas");
                Console.WriteLine("3 - auto durvju skaita");
                Console.WriteLine("0 - atgriezties Menu");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Ievadiet kadu krasu meklet!");
                        search = Console.ReadLine();
                        foreach(var a in car)
                        {

                            if(a.color.Contains(search))
                            {
                                if (a.color == search)
                                {
                                    Console.WriteLine("Tada krasa ir " + i + ". indeksa auto!");
                                    found = true;
                                }
                            }
                            i++;
                        }
                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Mekleta krasa nav nevienai masinai!");
                        }
                        i = 0;//sos i es lieku uz 0, jo radas problema, ka ar i++ vins muzigi skaitija un tadel jo vairak parbaudiju, tad 1. indekss vareja but 20, jo i pats sevi vienmer skaitija; sis bija mans kompromis, jo nevareju uztaisit for ciklu ka vajag (zemak bus redzams)
                        found = false;
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Ievadiet kadu marku meklet!");
                        search = Console.ReadLine();
                        foreach (var a in car)
                        {
                            if (a.brand.Contains(search))
                            {
                                if (a.brand == search)
                                {
                                    Console.WriteLine("Tada marka ir " + i + ". indeksa auto!");
                                    found = true;
                                }
                            }
                            i++;
                        }
                        if (!found)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Mekleta marka nav nevienai masinai!");
                        }
                        i = 0;
                        found = false;
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Ievadiet meklejamo durvju skaitu!");
                        try 
                        { 
                            int searchNum = Convert.ToInt32(Console.ReadLine());
                            foreach (var a in car)
                            {
                                //for(int i = 0; i < a.color.Count; i++) kapec sadi vins nelauj?
                                if (a.doors == searchNum)
                                {
                                    Console.WriteLine("Tads durvju skaits ir " + i + ". indeksa auto!");//kapec nevar izmantot - a.doors.IndexOf(searchNum) ?
                                    found = true;
                                }
                                i++;
                            }
                            if (!found)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Mekletais durvju skaits nav nevienai masinai!");
                            }
                            i = 0;
                            found = false;
                        }
                        catch
                        {
                            Console.WriteLine();
                            Console.WriteLine("Nepareiza ievade, ludzu, ievadiet ciparu!");
                            int newSearchNum = WrongInputCatch();
                            foreach (var a in car)
                            {
                                if (a.doors == newSearchNum)
                                {
                                    Console.WriteLine("Tads durvju skaits ir " + i + ". indeksa auto!");//kapec nevar izmantot - a.doors.IndexOf(searchNum) ?
                                }
                                i++;
                            }
                            if (!found)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Mekletais durvju skaits nav nevienai masinai!");
                            }
                            i = 0;
                            found = false;
                        }
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
