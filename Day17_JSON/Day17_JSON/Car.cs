using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_JSON
{
    class Car
    {
        public String brand;
        public String model;
        public int doorCount;

        public Car(String brand, String model, int doorCount)
        {
            this.brand = brand;
            this.model = model;
            this.doorCount = doorCount;//ar this norāda uz objektu, kuru veidos
        }
    }
}
