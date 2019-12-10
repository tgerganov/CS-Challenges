using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemSolvingTasks ProblemSolvingTasks = new ProblemSolvingTasks();

            Console.WriteLine("Reversing a string, example - my first name (Todor):");
            Console.WriteLine(ProblemSolvingTasks.ReverseString("Todor"));

            Console.WriteLine();

            Console.WriteLine("Checking if a string is a palindrome, example - kayak:");
            Console.WriteLine(ProblemSolvingTasks.IsPalindrome("kayak"));
            Console.WriteLine();

            Console.WriteLine("Checking if a string is a palindrome, example - boat:");
            Console.WriteLine(ProblemSolvingTasks.IsPalindrome("boat"));
            Console.WriteLine();

            Console.WriteLine("Returning the missing elements, example - [4, 6, 9]:");
            foreach (var element in ProblemSolvingTasks.MissingElements(new int[] { 4, 6, 9 }))
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Returning the missing elements, example - [2, 3, 4]:");
            foreach (var element in ProblemSolvingTasks.MissingElements(new int[] { 2, 3, 4 }))
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Returning the missing elements, example - [1, 3, 4]:");
            foreach (var element in ProblemSolvingTasks.MissingElements(new int[] { 1, 3, 4 }))
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
