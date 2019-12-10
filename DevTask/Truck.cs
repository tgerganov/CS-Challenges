using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTask
{
    class Truck:Vehicle
    {
        public int MaxLoad { get; set; }

        public Truck()
        {
            Type = "Truck";
            Make = "Scania";
            MaxLoad = 20;
        }

        public override string ToString()
        {
            string s = "Type: " + Type + "," + " Make: " + Make + "," + " MaxLoad: " + MaxLoad;
            return s;
        }

    }
}
