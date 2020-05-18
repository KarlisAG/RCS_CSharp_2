using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_OOP
{
    class Car : Vehicle//car manto visas īpašības no vehicle
    {
        public int doorCount;

        public Car(int doorCount, String brand)
        {
            this.doorCount = doorCount;
            this.brand = brand;
        }
    }
}
