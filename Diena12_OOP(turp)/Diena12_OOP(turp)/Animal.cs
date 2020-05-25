using System;
using System.Collections.Generic;
using System.Text;

namespace Diena12_OOP_turp_
{
    abstract class Animal
    {
        protected int legCount;
        protected bool hasWings;

        public void Action()
        {
            Move();
            MakeSound();
        }
        public abstract void Move();
        public abstract void MakeSound();

        public virtual void Sleep()
        {
            Console.WriteLine("The animal sleeps");
        }

        public abstract void Print();

    }

    
}
