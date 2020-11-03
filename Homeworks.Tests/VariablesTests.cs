using NUnit.Framework;
using Homeworks;

namespace Homeworks.Tests
{
    public class VariablesTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(3, 2, -19)]
        [TestCase(-7, 9, 2.875)]
        [TestCase(4, 1, -7)]

        public void DoMathProblemTest(double a, double b, double expected)
        {
            double actual = Variables.DoMathProblem(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3)]
        [TestCase(0, 0)]
        [TestCase(-5, -5)]

        public void DoMathProblemTestNegative(double a, double b)
        {
            try
            {
                Variables.DoMathProblem(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(3, 1, new int[2] { 3, 0 })]
        [TestCase(16, 2, new int[2] { 8, 0 })]
        [TestCase(5, 13, new int[2] { 0, 5 })]
        [TestCase(13, 6, new int[2] { 2, 1 })]

        public void MakeTheResultOfTheDivisionAndRemainderTest(int a, int b, int[] expected)
        {
            int[] actual = Variables.MakeTheResultOfTheDivisionAndRemainder(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 0)]
        [TestCase(-4, 0)]

        public void MakeTheResultOfTheDivisionAndRemainderTestNegative(int a, int b)
        {
            try
            {
                Variables.MakeTheResultOfTheDivisionAndRemainder(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, 1, 4, 1.5)]
        [TestCase(1, 2, 3, 1)]
        [TestCase(-5, 0, 12, -2.4)]
        [TestCase(4, -11.5, 3.5, 3.75)]

        public void LookinForASolutionToTheEquationTest(double a, double b, double c, double expected)
        {
            double actual = Variables.LookinForASolutionToTheEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, 4)]
        [TestCase(0, -7, 12)]

        public void LookinForASolutionToTheEquationTestNegative(double a, double b, double c)
        {
            try
            {
                Variables.LookinForASolutionToTheEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, -3, 2, 8, "y = -1,5x + 3,5")]
        [TestCase(-5, -3, -13, -22, "y = -4,5x - 35,5")]
        [TestCase(2, 7, -1.5, 9, "y = 2,1x - 5,7")]
        [TestCase(8.5, -3.5, -1.5, 4.5, "y = -0,5x + 2,75")]
        [TestCase(1, 3, 2, 6, "y = 2x")]

        public void FindTheEquationOfAStraightLineByPointsTest(double x1, double x2, double y1, double y2, string expected)
        {
            string actual = Variables.FindTheEquationOfAStraightLineByPoints(x1, x2, y1, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, -3, 8)]
        [TestCase(2, -4, -7, -7)]

        public void FindTheEquationOfAStraightLineByPointsTestNegative(double x1, double x2, double y1, double y2)
        {
            try
            {
                Variables.FindTheEquationOfAStraightLineByPoints(x1, x2, y1, y2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}