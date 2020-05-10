using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Day7__Objects_Objekti
{
    class Shape
    {
        private int mala1;
        private int mala2;
        private int mala3;
        private int mala4;
        private int mala5;

        public Shape(int mala1, int mala2, int mala3)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
        }
        public Shape(int mala1, int mala2, int mala3, int mala4)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
            this.mala4 = mala4;
        }
        public Shape(int mala1, int mala2, int mala3, int mala4, int mala5)
        {
            this.mala1 = mala1;
            this.mala2 = mala2;
            this.mala3 = mala3;
            this.mala4 = mala4;
            this.mala5 = mala5;
        }

        public void Print()
        {
            if (this.mala4 == 0 && mala5 == 0)
            {
                Console.WriteLine(mala1 + " " + mala2 + " " + mala3);
            }
            else if (mala5 == 0)
            {
                Console.WriteLine(mala1 + " " + mala2 + " " + mala3 + " " + mala4); 
            }
            else Console.WriteLine(mala1 + " " + mala2 + " " + mala3 + " " + mala4 + " " + mala5);
        }

        public void Perimeter()
        {
            if (this.mala4 == 0 && this.mala5 == 0)
            {
                Console.WriteLine(mala1 + mala2 + mala3);
            }
            else if (this.mala5 == 0)
            {
                Console.WriteLine(mala1 + mala2 + mala3 + mala4);
            }
            else Console.WriteLine(mala1 + mala2 + mala3 + mala4 + mala5);
        }
    }
}
