using System;

namespace Day11_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Drive();
            Console.WriteLine("--------");

            Car c = new Car(2, "Volvo");
            c.Drive();//var izmantot arī Vehicle klases metodi
            //manot visas publiskās un protected metodes/īpašības
            //private no Vehicle Car nevar dabūt

            //manotšana ir lai ietaupītu rindu skaitu klasēm, kas dala tādas pašas īpašības
            //ķēdē nevar mantot no 1 uz 2, uz 3; c++ tā var; var no bāzes mantot un viss
            Bike b = new Bike();
            b.Drive();
        }
    }
}
