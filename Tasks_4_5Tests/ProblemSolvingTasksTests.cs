using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks_4_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_4_5.Tests
{
    [TestClass()]
    public class ProblemSolvingTasksTests
    {
        [TestMethod()]
        public void ReverseStringTest()
        {
            string toBeReversed = "Todor";
            string expectedResult = "rodoT";
            string actualResult;

            actualResult = ProblemSolvingTasks.ReverseString(toBeReversed);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void IsPalindromeTest_Palindrome()
        {
            string toBeTested = "kayak";
            bool expectedResult = true;
            bool actualResult;

            actualResult = ProblemSolvingTasks.IsPalindrome(toBeTested);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void IsPalindromeTest_Not_Palindrome()
        {
            string toBeTested = "boat";
            bool expectedResult = false;
            bool actualResult;

            actualResult = ProblemSolvingTasks.IsPalindrome(toBeTested);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void IsPalindromeTest_CapLetter() // Since my original method is case-sensitive
        {
            string toBeTested = "Kayak";
            bool expectedResult = false;
            bool actualResult;

            actualResult = ProblemSolvingTasks.IsPalindrome(toBeTested);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MissingElementsTest()
        {
            int[] arrayToCheck = { 4, 6, 9 };
            IEnumerable<int> expectedResult = new List<int> { 5, 7, 8 };
            IEnumerable<int> actualResult;

            actualResult = ProblemSolvingTasks.MissingElements(arrayToCheck);

            CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
        }

        [TestMethod()]
        public void MissingElementsTest_NoMissingOnes()
        {
            int[] arrayToCheck = { 2, 3, 4 };
            IEnumerable<int> expectedResult = new List<int>();
            IEnumerable<int> actualResult;

            actualResult = ProblemSolvingTasks.MissingElements(arrayToCheck);

            CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
        }
    }
}