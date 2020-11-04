using NUnit.Framework;

namespace Homeworks.Tests
{
    class TDArraysTests
    {
        int[,] aMock;
        int[,] expectedMock;
        void GetMock(int n)
        {
            switch (n)
            {
                case 1:
                    aMock = new int[,]
                    {
                        {1, 2, 3},
                        {4, 5, 6},
                        {7, 8, 9}
                    };
                    expectedMock = new int[,]
                    {
                        {1, 4, 7},
                        {2, 5, 8},
                        {3, 6, 9}
                    };
                    break;
                case 2:
                    aMock = new int[,]
                    {
                        {-1, 2, 53, 81},
                        {24, -5, -6, -11},
                        {-7, 8, 19, 0}
                    };
                    expectedMock = new int[,]
                    {
                        {-1, 24, -7},
                        {2, -5, 8},
                        {53, -6, 19},
                        {81, -11, 0}
                    };
                    break;
                case 3:
                    aMock = new int[,]
                    {
                        {21, 33, -17},
                        {-4, 8, 7},
                        {-13, 8, 0},
                        {12, -3, 41}
                    };
                    expectedMock = new int[,]
                    {
                        {21, -4, -13, 12},
                        {33, 8, 8, -3},
                        {-17, 7, 0, 41}
                    };
                    break;
            }
        }

        [TestCase(1, 1)]
        [TestCase(2, -11)]
        [TestCase(3, -17)]
        public void GetMinimalElementTest(int n, int expected)
        {
            GetMock(n);
            int[,] array = aMock;
            int actual = TDArrays.GetMinimalElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 81)]
        [TestCase(3, 41)]
        public void GetMaximalElementTest(int n, int expected)
        {
            GetMock(n);
            int[,] array = aMock;
            int actual = TDArrays.GetMaximalElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[2] { 0, 0 })]
        [TestCase(2, new int[2] { 1, 3 })]
        [TestCase(3, new int[2] { 0, 2 })]
        public void GetIndexOfMinimalElementTest(int n, int[] expected)
        {
            GetMock(n);
            int[,] array = aMock;
            int[] actual = TDArrays.GetIndexOfMinimalElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[2] { 2, 2 })]
        [TestCase(2, new int[2] { 0, 3 })]
        [TestCase(3, new int[2] { 3, 2 })]
        public void GetIndexOfMaximalElementTest(int n, int[] expected)
        {
            GetMock(n);
            int[,] array = aMock;
            int[] actual = TDArrays.GetIndexOfMaximalElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 3)]
        [TestCase(3, 3)]
        public void GetNumberOfElementsThatBiggerTheirNeighborsTest(int n, int expected)
        {
            GetMock(n);
            int[,] array = aMock;
            int actual = TDArrays.GetNumberOfElementsThatBiggerTheirNeighbors(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TransposeTheMatrix(int n)
        {
            GetMock(n);
            int[,] array = aMock;
            int[,] expected = expectedMock;
            int[,] actual = TDArrays.TransposeTheMatrix(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
