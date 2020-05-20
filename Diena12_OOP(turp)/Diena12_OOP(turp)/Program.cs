using System;

namespace Diena12_OOP_turp_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog(4, false, true);
            d.Action();
            Console.WriteLine();

            Cat c = new Cat(4, false, true);
            c.Action();
            Console.WriteLine();

            Parrot p = new Parrot(2, true, true);
            p.Action();
            Console.WriteLine();

            Sparrow s = new Sparrow(2, true, "brown");
            s.Action();
            Console.WriteLine();

            d.Print();
            c.Print();
            p.Print();
            s.Print();
        }
    }
}
