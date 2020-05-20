using System;
using System.Collections.Generic;
using System.Text;

namespace Diena12_OOP_turp_
{
    class Dog : Animal
    {
        private bool likesWalks;

        public Dog(int legCount, bool hasWings, bool likesWalks)
        {
            this.legCount = legCount;
            this.hasWings = hasWings;
            this.likesWalks = likesWalks;
        }
        public override void Move()
        {
            Console.WriteLine("Dog runs");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Bark-bark");
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.Write("This is a dog. It has " + legCount + " legs and it ");
            Console.Write(hasWings ? "has wings " : "does not have wings ");
            Console.Write(likesWalks ? "and it likes walks" : "and doesnt likes walks");
        }

        public override void Sleep()
        {
            Console.WriteLine("snore");
        }
    }
}
