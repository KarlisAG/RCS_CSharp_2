using System;
using System.Collections.Generic;
using System.Text;

namespace Diena12_OOP_turp_
{
    class Parrot : Animal
    {
        private bool isExotic;

        public Parrot(int legCount, bool hasWings, bool isExotic)
        {
            this.legCount = legCount;
            this.hasWings = hasWings;
            this.isExotic = isExotic;
        }
        public override void Move()
        {
            Console.WriteLine("Parrot flies");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Immitates human noises");
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.Write("This is a parrot. It has " + legCount + " legs and it ");
            Console.Write(hasWings ? "has wings " : "does not have wings ");
            Console.Write(isExotic ? "and it is exotic" : "and it isnt exotic");
        }

        public override void Sleep()
        {
            Console.WriteLine("ZZZ");
        }
    }
}
