using Homeworks;
using NUnit.Framework;
using System;

namespace Homeworks.Tests
{
    public class ForksTests
    {
        [TestCase(5, 2, 7)]
        [TestCase(11, 5, 16)]
        [TestCase(3, 3, 9)]
        [TestCase(6, 6, 36)]
        [TestCase(4, 15, -11)]
        [TestCase(2, 5, -3)]
        public void PerformsTheCalculationDependingOnTheComparisonTest(int a, int b, int expected)
        {
            int actual = Forks.PerformsTheCalculationDependingOnTheComparison(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2, 1)]
        [TestCase(16, 5, 1)]
        [TestCase(5, -2, 2)]
        [TestCase(8, -11, 2)]
        [TestCase(-17, -12, 3)]
        [TestCase(-35, -21, 3)]
        [TestCase(-6, 2, 4)]
        [TestCase(-13, 2, 4)]
        public void OutputTheNumberOfTheQuarterOfTheCoordinateAxisTest(int x, int y, int expected)
        {
            int actual = Forks.OutputTheNumberOfTheQuarterOfTheCoordinateAxis(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2, 1, new int[3] { 1, 2, 3 })]
        [TestCase(-5, 2, 12, new int[3] { -5, 2, 12 })]
        [TestCase(3, 22, -1, new int[3] { -1, 3, 22 })]

        public void SortingOfThreeNumbersTest(int a, int b, int c, int[] expected)
        {
            int[] actual = Forks.SortingOfThreeNumbers(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1, new double[1] { -1 })]
        [TestCase(4, 2, 8, new double[0])]
        [TestCase(2, -9, 4, new double[2] { 4, 0.5 })]
        [TestCase(-1, 7, -10, new double[2] { 2, 5 })]

        public void SolvesTheQuadraticEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual = Forks.SolvesTheQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, 1)]

        public void SolvesTheQuadraticEquationNegativTest(double a, double b, double c)
        {
            try
            {
                Forks.SolvesTheQuadraticEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(25, "двадцать пять")]
        [TestCase(12, "двенадцать")]
        [TestCase(10, "десять")]
        [TestCase(67, "шестьдесят семь")]

        public void ReturnsAnUppercaseEntryOfATwoDigitNumberTest(int number, string expected)
        {
            string actual = Forks.ReturnsAnUppercaseEntryOfATwoDigitNumber(number);
            Assert.AreEqual(expected, actual);
        }
    }
}