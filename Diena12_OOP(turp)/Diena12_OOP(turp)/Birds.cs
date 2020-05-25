using System;
using System.Collections.Generic;
using System.Text;

namespace Diena12_OOP_turp_
{
    class Birds : Animal
    {
        private bool isExotic;
        private String color;
        public Birds(int legCount, bool hasWings, bool isExotic, String color)
        {
            this.legCount = legCount;
            this.hasWings = hasWings;
            this.isExotic = isExotic;
            this.color = color;
        }

        public Birds(int legCount, bool hasWings, bool isExotic)
        {
            this.legCount = legCount;
            this.hasWings = hasWings;
            this.isExotic = isExotic;
        }

        public override void MakeSound()
        {
            Console.WriteLine(isExotic ? "Immitates human noises" : "Squak-squak");
        }

        public override void Move()
        {
            Console.WriteLine();
            Console.Write(isExotic ? "The parrot " : "The sparrow ");
            Console.WriteLine("flies away");
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.Write(isExotic ? "The parrot " : "The sparrow ");
            Console.Write("has " + legCount + " legs and it ");
            Console.Write(hasWings ? "has wings " : "does not have wings ");
            Console.Write(isExotic ? "and it is exotic" : "and it isnt exotic");
        }

        public new void Sleep()
        {
            Console.WriteLine(isExotic ? "zzz" : "ZZZ");
        }
    }
}
