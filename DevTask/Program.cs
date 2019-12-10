using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DevTask
{
    class Program // Entry point for tasks 1, 2 and 3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All vehicles sorted alphabetically by type: ");
            Console.WriteLine("============================================");
            foreach (var vehicle in InstanceService.GetInstances())
            {
                Console.WriteLine(vehicle);
            }

            Console.WriteLine();

            SaveToDisc();
            Console.WriteLine("Vehicle instances saved to disk, file can be found under Brugere > Delte filer.");
            Console.WriteLine();

            Console.WriteLine("Let us e.g. find the bicycle by typing \"cyc\": \n{0}", FindVehicle("cyc"));
            Console.WriteLine();

            Console.ReadKey();
        }

        public static Vehicle FindVehicle(string partOfName)
        {
            List<Vehicle> vehicles = InstanceService.GetInstances().ToList();
            return vehicles.Find(x => x.Type.Contains(partOfName));
        }

        public static void SaveToDisc()
        {
            using (StreamWriter file = new StreamWriter(@"C:\Users\Public\VehicleInstances.txt")) // Brugere > Delte filer
            {
                foreach (var vehicle in InstanceService.GetInstances())
                {
                    file.WriteLine(vehicle);
                }
            }
        }
    }
}
