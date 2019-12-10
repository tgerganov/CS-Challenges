using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTask
{
    class InstanceService
    {
        public static IEnumerable<Vehicle> GetInstances()
        {
            IList<Vehicle> vehicleList = new List<Vehicle>()
            {
                new Car(),
                new Bicycle(),
                new Truck()
            };
            return vehicleList.OrderBy(Type => Type);
        }
    }
}
