using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGame
{
    class Hand
    {
        public List<Car> cars = new List<Car>();
        
        public List<Car> KmHAbove (int kmH)
        {
            var fastList = new List<Car>();

            foreach(Car car in cars)
            {
                if (car.KmH > kmH)
                {
                    fastList.Add(car);
                }
            }

            fastList.ForEach(Console.WriteLine);

            return fastList;
        }
    }
}
