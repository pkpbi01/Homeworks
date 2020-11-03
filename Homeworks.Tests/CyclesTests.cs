using NUnit.Framework;

namespace Homeworks.Tests
{
    class CyclesTests
    {
        [TestCase(3, 2, 9)]
        [TestCase(4, 5, 1024)]
        [TestCase(8, -3, 0.001953125)]
        [TestCase(5, -2, 0.04)]
        public void RaiseToADegreeTest(int a, int b, double expected)
        {
            double actual = Cycles.RaiseToADegree(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, new int[10] {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000})]
        [TestCase(250, new int[4] {250, 500, 750, 1000})]
        [TestCase(325, new int[3] {325, 650, 975})]
        [TestCase(1035, new int[0])]
        public void ReturnNumbersDivisibleByNTest(int a, int[] expected)
        {
            int[] actual = Cycles.ReturnNumbersDivisibleByN(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 9)]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void SearchForNumbersWhoseSquareIsLessThanNTest(int a, int expected)
        {
            int actual = Cycles.SearchForNumbersWhoseSquareIsLessThanN(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void ReturnTheLargestDivisor(int a, int expected)
        {
            int actual = Cycles.ReturnTheLargestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void CalculateTheSumOfNumbersDivisibleBySevenInTheRangeTest(int a, int b, int expected)
        {
            int actual = Cycles.CalculateTheSumOfNumbersDivisibleBySevenInTheRange(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void ReturnTheNthTermOfTheFibonacciSeriesTest(int n, int expected)
        {
            int actual = Cycles.ReturnTheNthTermOfTheFibonacciSeries(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void FindTheGreatestCommonDivisorTest(int a, int b, int expected)
        {
            int actual = Cycles.FindTheGreatestCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void CalculateTheCubicRootTest(int n, int expected)
        {
            int actual = Cycles.CalculateTheCubicRoot(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void FindTheNumberOfOddDigitsOfANumberTest(int n, int expected)
        {
            int actual = Cycles.FindTheNumberOfOddDigitsOfANumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void FindTheMirrorImageOfANumberTest(int n, int expected)
        {
            int actual = Cycles.FindTheMirrorImageOfANumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void ReturnTheNumberOfNumbersWhereTheSumOfEvenDigitsIsGreaterThanOddTest(int n, int expected)
        {
            int actual = Cycles.ReturnTheNumberOfNumbersWhereTheSumOfEvenDigitsIsGreaterThanOdd(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void FindIfThereAreIdenticalDigitsInTwoNumbersTest(int a, int b, bool expected)
        {
            bool actual = Cycles.FindIfThereAreIdenticalDigitsInTwoNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }


    }
}
