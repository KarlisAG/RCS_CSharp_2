using System;

namespace Diena12_OOP_turp_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog(4, false, true);
            d.Action();
            d.Sleep();
            Console.WriteLine();

            Cat c = new Cat(4, false, true);
            c.Action();
            c.Sleep();
            Console.WriteLine();

            Birds b = new Birds(2, true, true);
            b.Action();
            b.Sleep();
            Console.WriteLine();

            Birds b2 = new Birds(2, true, false,  "brown");
            b2.Action();
            b2.Sleep();
            Console.WriteLine();

            d.Print();
            c.Print();
            b.Print();
            b2.Print();
        }
    }
}
