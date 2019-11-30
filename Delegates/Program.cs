using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Delegate types to describe predicates on ints and actions on ints. 
    public delegate bool IntPredicate(int x);
    public delegate void IntAction(int x); 

    // Integer lists with Act and Filter operations. 
    // An IntList containing the element 7 9 13 may be constructed as  
    // new IntList(7, 9, 13) due to the params modifier. 
    class IntList : List<int>
    {
        public IntList(params int[] elements) : base(elements)
        {
        }

        public void Act(IntAction f)
        {
            foreach (int i in this)
            {
                f(i);
            }
        }

        public IntList Filter(IntPredicate p)
        {
            IntList res = new IntList();
            foreach (int i in this)
                if (p(i))
                    res.Add(i);
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IntList myList = new IntList(7, 9, 13, 4, 16, 28, 33, 42);
            Console.WriteLine("Printing all numbers from the original list:");
            myList.Act(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Printing the newly created list with even numbers:");
            myList.Filter(delegate (int x) { return x % 2 == 0; }).Act(Console.WriteLine);
            //There are two lists in total. The second one comes from the Filter method which creates a new list containing only the even elements from the original one (myList).
            Console.WriteLine();

            Console.WriteLine("Printing the newly created list with odd numbers:");
            myList.Filter(delegate (int x) { return x % 2 != 0; }).Act(Console.WriteLine);
            //Here I say "Okay, give me also the odd numbers". This would add (by creating a new) another list to the total number - original (all elements), even, odd.
            Console.WriteLine();

            Console.WriteLine("Another simple example of an action on all elements:");
            myList.Act(delegate (int x) { Console.WriteLine("The squared element is {0}", x * x); });
            Console.WriteLine();

            //Here we define a predicate and say "Show me a list containing only the numbers which conform to my condition."
            Console.WriteLine("Printing the newly created list with numbers >= 25 (our predicate):");
            myList.Filter(delegate (int x) { return x >= 25; }).Act(Console.WriteLine);
            Console.WriteLine();

            //Here we compute the sum of myList's elements by declaring and initializing a local variable which acts as an accumulator
            Console.WriteLine("Computing the sum of myList's elements:");
            int sum = 0;
            myList.Act(delegate (int x) { sum += x; Console.WriteLine("The accumulated sum: {0}", sum); });
            Console.WriteLine();
            Console.WriteLine("The sum of myList's elements is: {0}", sum);
            Console.WriteLine();
            Console.ReadKey();

            //I play around a little bit here
            //IntAction adding = delegate (int x) { sum += x; Console.WriteLine("The sum is: {0}", sum); };
            //myList.Act(adding);

        }
    }
}
