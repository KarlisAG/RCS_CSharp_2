using System;
using System.Collections.Generic;
using System.Text;

namespace Diena12_OOP_turp_
{
    class Sparrow : Animal
    {
        private String color;
        public Sparrow(int legCount, bool hasWings, String color)
        {
            this.legCount = legCount;
            this.hasWings = hasWings;
            this.color = color;
        }

        public override void Move()
        {
            Console.WriteLine("Sparrow flies");
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("Squak-squak");
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.Write("This is a sparrow. It has " + legCount + " legs and it ");
            Console.Write(hasWings ? "has wings " : "does not have wings ");
            Console.Write(" and it is " + color);
        }

        public override void Sleep()
        {
            Console.WriteLine("zzz");
        }
    }
}
