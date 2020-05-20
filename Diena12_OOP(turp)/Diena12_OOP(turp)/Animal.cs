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
            Sleep();
        }
        public abstract void Move();
        public abstract void MakeSound();

        public abstract void Sleep();

        public abstract void Print();

    }

    
}
