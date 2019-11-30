using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGame
{
    class Car : IComparable<Car>
    {
        public string Make { get; set; }
        public int KmH { get; set; }
        public int PS { get; set; }
        public int UMin { get; set; }
        public int Ccm { get; set; }
        public double ZeroToHundred { get; set; }
        public int Zylinder { get; set; }

        public Car(string Make, int KmH, int PS, int UMin, int Ccm, double ZeroToHundred, int Zylinder)
        {
            this.Make = Make;
            this.KmH = KmH;
            this.PS = PS;
            this.UMin = UMin;
            this.Ccm = Ccm;
            this.ZeroToHundred = ZeroToHundred;
            this.Zylinder = Zylinder;
        }

        public int CompareTo(Car other)
        {
            if (other.KmH > KmH)
                return 1;
            else if (other.KmH < KmH)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            string s = "Make:" + Make + " MaxSpeed:" + KmH + " HP:" + PS + " RPM:" + UMin + " CubicCm:" + Ccm + " Acc0to100:" + ZeroToHundred + " Cylinders:" + Zylinder;
            return s;
        }
    }

    class MyKmHComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.KmH - y.KmH;
        }
    }

    class MyPSComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.PS - y.PS;
        }
    }

    class MyUMinComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.UMin - y.UMin;
        }
    }

    class MyCcmComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Ccm - y.Ccm;
        }
    }

    class MyZeroToHundredComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.ZeroToHundred > y.ZeroToHundred)
                return 1;
            else if (x.ZeroToHundred < y.ZeroToHundred)
                return -1;
            else
                return 0;
        }
    }

    class MyZylinderComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Zylinder - y.Zylinder;
        }
    }
}
