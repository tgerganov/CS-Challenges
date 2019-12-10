using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTask
{
    class Bicycle:Vehicle
    {
        public string Color { get; set; }

        public Bicycle()
        {
            Type = "Bicycle";
            Make = "BMX";
            Color = "Red";
        }

        public override string ToString()
        {
            string s = "Type: " + Type + "," + " Make: " + Make + "," + " Color: " + Color;
            return s;
        }

    }
}
