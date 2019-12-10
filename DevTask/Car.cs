using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTask
{
    class Car:Vehicle
    {
        public int MaxSpeed { get; set; }

        public Car()
        {
            Type = "Car";
            Make = "Tesla";
            MaxSpeed = 300;
        }

        public override string ToString()
        {
            string s = "Type: " + Type + "," + " Make: " + Make + "," + " MaxSpeed: " + MaxSpeed;
            return s;
        }

    }
}
