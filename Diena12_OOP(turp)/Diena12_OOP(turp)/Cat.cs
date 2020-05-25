using System;
using System.Collections.Generic;
using System.Text;

namespace Diena12_OOP_turp_
{
    class Cat : Animal
    {
        private bool sleepsALot;
        public Cat(int legCount, bool hasWings, bool sleepsALot)
        {
            this.legCount = legCount;
            this.hasWings = hasWings;
            this.sleepsALot = sleepsALot;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public override void Move()
        {
            Console.WriteLine("Cat walks");
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.Write("This is a cat. It has " + legCount + " legs and it ");
            Console.Write(hasWings ? "has wings " : "does not have wings ");
            Console.Write(sleepsALot ? "and it sleeps a lot" : "and it doesnt sleep a lot");
        }

        public override void Sleep()
        {
            Console.WriteLine("Quiet snore");
        }
    }
}
