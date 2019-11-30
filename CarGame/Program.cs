using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand();

            hand.cars.Add(new Car("Mercedes SL320", 280, 400, 6500, 3000, 4.2, 6));
            hand.cars.Add(new Car("Opel Omega", 220, 160, 4000, 1800, 6.7, 4));
            hand.cars.Add(new Car("Peugeot 508", 240, 165, 4700, 1900, 5.3, 4));
            hand.cars.Add(new Car("Lamborghini Veneno", 290, 320, 5800, 2700, 3.6, 6));
            hand.cars.Add(new Car("Kia Picanto", 180, 100, 3500, 1100, 9.3, 3));
            hand.cars.Add(new Car("VW Golf", 210, 120, 3000, 1400, 7.1, 4));

            Console.WriteLine();
            Console.WriteLine("The cars before they are sorted:");
            Console.WriteLine("======================");
            hand.cars.ForEach(Console.WriteLine);
            Console.WriteLine();

            hand.cars.Sort();
            Console.WriteLine("The cars after they are sorted by the default sort method by max speed:");
            Console.WriteLine("======================");
            hand.cars.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Printing all the cars whose max speed is e.g. greater than 250 km/h:");
            Console.WriteLine("======================");
            hand.KmHAbove(250);
            Console.WriteLine();

            hand.cars.Sort(new MyKmHComparer());
            Console.WriteLine("The ranking of the cars by speed:");
            Console.WriteLine("======================");
            hand.cars.ForEach(Console.WriteLine);
            Console.WriteLine();

            hand.cars.Sort(new MyPSComparer());
            Console.WriteLine("The ranking of the cars by HP:");
            Console.WriteLine("======================");
            hand.cars.ForEach(Console.WriteLine);
            Console.WriteLine();

            hand.cars.Sort(new MyUMinComparer());
            Console.WriteLine("The ranking of the cars by RPM:");
            Console.WriteLine("======================");
            hand.cars.ForEach(Console.WriteLine);
            Console.WriteLine();

            hand.cars.Sort(new MyCcmComparer());
            Console.WriteLine("The ranking of the cars by cubic cm:");
            Console.WriteLine("======================");
            hand.cars.ForEach(Console.WriteLine);
            Console.WriteLine();

            hand.cars.Sort(new MyZeroToHundredComparer());
            Console.WriteLine("The ranking of the cars by acceleration:");
            Console.WriteLine("======================");
            hand.cars.ForEach(Console.WriteLine);
            Console.WriteLine();

            hand.cars.Sort(new MyZylinderComparer());
            Console.WriteLine("The ranking of the cars by cylinders:");
            Console.WriteLine("======================");
            hand.cars.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
