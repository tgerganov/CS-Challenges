using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTask
{
    class Vehicle:IComparable<Vehicle>
    {
        public string Type { get; set; }
        public string Make { get; set; }

        public int CompareTo(Vehicle other)
        {
            return Type.CompareTo(other.Type); 
        }
    }
}
