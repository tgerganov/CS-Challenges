using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_4_5
{
    public class ProblemSolvingTasks
    {
        public static string ReverseString(string s)
        {
            string reverseString = "";
            int length;

            length = s.Length - 1;

            while (length >= 0)
            {
                reverseString = reverseString + s[length];
                length--;
            }

            return reverseString;
        }

        public static bool IsPalindrome(string s)
        {
            string reverseString = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverseString += s[i].ToString();
            }

            // ...or by simply using my own method: 
            // string reverseString = ReverseString(s);

            if (reverseString == s)
            {
                Console.WriteLine("The string is a palindrome, input = {0}, output = {1}", s, reverseString);
                return true;
            }
            else
            {
                Console.WriteLine("The string is NOT a palindrome, input = {0}, output = {1}", s, reverseString);
                return false;
            }
        }

        public static IEnumerable<int> MissingElements(int[] arr)
        {
            var missingElements = new List<int>();

            arr.Aggregate((prev, curr) =>
            {
                var diff = curr - prev - 1;
                if (diff > 0)
                {
                    missingElements.AddRange(Enumerable.Range(curr - diff, diff));
                }
                return curr;
            });

            return missingElements;
        }
    }
}
