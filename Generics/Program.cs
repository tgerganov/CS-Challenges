using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //(a) ========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========
    public struct Pair<T, U>
    {
        public readonly T first;
        public readonly U second;
        public Pair(T fst, U snd)
        {
            this.first = fst;
            this.second = snd;
        }
        public override String ToString()
        {
            return "(" + first + ", " + second + ")";
        }
        
        //(h)
        public Pair<U, T> Swap()
        {
            return new Pair<U, T>(second, first);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //(b)
            Pair<String, int> pair1 = new Pair<String, int>("Kurt", 13);

            //(c)
            Pair<String, double> pair2 = new Pair<String, double>("Phoenix", 39.7);
            
            //(d) We cannot (are not allowed) to do this:
            //"Cannot implicitly convert type 'Assignment_3.Pair<string, int>' to 'Assignment_3.Pair<string, double>'
            //Generics gives us the possibility to instantiate with whatever type we would love to, however once defined, we should conform to it (the type)
            //Generics help us by providing type safety and reusability
            //Pair<String, double> pair2a = new Pair<String, int>("Phoenix", 39);

            //(e)
            Pair<String, int>[] grades = new Pair<String, int>[5];
            grades[0] = new Pair<String, int>("Example1", 1);
            grades[1] = new Pair<String, int>("Example2", 2);
            grades[2] = new Pair<String, int>("Example3", 3);

            //(f)
            //Result: (Example1, 1) (Example2, 2) (Example3, 3) (, 0) (, 0)
            //The values of grades[3] and grades[4] are pairs of an empty string and an int 0 (zero)
            foreach(Pair<String, int> pair in grades)
            {
                Console.WriteLine(pair);
            }

            //(g)
            //The type of appointment.first.second is int (2)
            Pair<Pair<int, int>, String> appointment = new Pair<Pair<int, int>, String>(new Pair<int, int>(1, 2), "Example");
            Console.WriteLine();
            Console.WriteLine(appointment); //((1, 2), Example)
            Console.WriteLine(appointment.first.second); //2
            Console.WriteLine(appointment.first.second.GetType()); //System.Int32
            Console.WriteLine();

            //(h) Test
            Console.WriteLine(appointment.Swap());
            Console.WriteLine(grades[0].Swap());
            Console.WriteLine(pair1.Swap());
            Console.WriteLine(pair2.Swap());

            Console.ReadKey();
        }
    }
}
