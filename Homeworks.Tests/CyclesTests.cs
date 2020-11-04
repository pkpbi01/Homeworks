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
        //-------------------------------------------------------------------------------------
        [TestCase(100, new int[10] {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000})]
        [TestCase(250, new int[4] {250, 500, 750, 1000})]
        [TestCase(325, new int[3] {325, 650, 975})]
        [TestCase(1035, new int[0])]
        public void ReturnNumbersDivisibleByNTest(int a, int[] expected)
        {
            int[] actual = Cycles.ReturnNumbersDivisibleByN(a);
            Assert.AreEqual(expected, actual);
        }
        //-------------------------------------------------------------------------------------


        [TestCase(100, 9)]
        [TestCase(10, 3)]
        [TestCase(50, 7)]
        [TestCase(-2, 0)]
        public void SearchForNumbersWhoseSquareIsLessThanNTest(int a, int expected)
        {
            int actual = Cycles.SearchForNumbersWhoseSquareIsLessThanN(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, 5)]
        [TestCase(20, 10)]
        [TestCase(122, 61)]
        [TestCase(61, 1)]
        public void ReturnTheLargestDivisor(int a, int expected)
        {
            int actual = Cycles.ReturnTheLargestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 15, 21)]
        [TestCase(100, 120, 336)]
        [TestCase(50, 30, 126)]
        [TestCase(-10, 20, 14)]
        public void CalculateTheSumOfNumbersDivisibleBySevenInTheRangeTest(int a, int b, int expected)
        {
            int actual = Cycles.CalculateTheSumOfNumbersDivisibleBySevenInTheRange(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(5, 3)]
        [TestCase(12, 89)]
        public void ReturnTheNthTermOfTheFibonacciSeriesTest(int n, int expected)
        {
            int actual = Cycles.ReturnTheNthTermOfTheFibonacciSeries(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 6, 2)]
        [TestCase(20, 5, 5)]
        [TestCase(120, 130, 10)]
        [TestCase(100, 80, 20)]
        public void FindTheGreatestCommonDivisorTest(int a, int b, int expected)
        {
            int actual = Cycles.FindTheGreatestCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 3)]
        [TestCase(64, 4)]
        [TestCase(2197, 13)]
        [TestCase(729, 9)]
        [TestCase(6859, 19)]
        public void CalculateTheCubicRootTest(int n, int expected)
        {
            int actual = Cycles.CalculateTheCubicRoot(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12543, 3)]
        [TestCase(14733, 4)]
        [TestCase(1, 1)]
        [TestCase(689, 1)]
        public void FindTheNumberOfOddDigitsOfANumberTest(int n, int expected)
        {
            int actual = Cycles.FindTheNumberOfOddDigitsOfANumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 321)]
        [TestCase(258, 852)]
        [TestCase(186, 681)]
        [TestCase(246845, 548642)]
        public void FindTheMirrorImageOfANumberTest(int n, int expected)
        {
            int actual = Cycles.FindTheMirrorImageOfANumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 4)]
        [TestCase(50, 24)]
        [TestCase(25, 12)]
        [TestCase(114, 49)]
        public void ReturnTheNumberOfNumbersWhereTheSumOfEvenDigitsIsGreaterThanOddTest(int n, int expected)
        {
            int actual = Cycles.ReturnTheNumberOfNumbersWhereTheSumOfEvenDigitsIsGreaterThanOdd(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(154, 879, false)]
        [TestCase(138, 536, true)]
        [TestCase(1549, 2473, true)]
        [TestCase(17674, 28933, false)]
        public void FindIfThereAreIdenticalDigitsInTwoNumbersTest(int a, int b, bool expected)
        {
            bool actual = Cycles.FindIfThereAreIdenticalDigitsInTwoNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }


    }
}
