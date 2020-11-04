using NUnit.Framework;

namespace Homeworks.Tests
{
    class ArraysTests
    {
        [TestCase(new int[5] {-1, 2, 5, 44, -10}, -10)]
        [TestCase(new int[4] {0, 55, -45, 100}, -45)]
        [TestCase(new int[3] {5, 8, 1}, 1)]
        [TestCase(new int[6] {8, 4, 55, -87, 0, 2}, -87)]
        public void GetMinimalElementTest(int[] array, int expected)
        {
            int actual = Arrays.GetMinimalElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 2, 5, 44, -10 }, 44)]
        [TestCase(new int[4] { 0, 55, -45, 100 }, 100)]
        [TestCase(new int[3] { 5, 8, 1 }, 8)]
        [TestCase(new int[6] { 8, 4, 55, -87, 0, 2 }, 55)]
        public void GetMaximalElementTest(int[] array, int expected)
        {
            int actual = Arrays.GetMaximalElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 2, 5, 44, -10 }, 4)]
        [TestCase(new int[4] { 0, 55, -45, 100 }, 2)]
        [TestCase(new int[3] { 5, 8, 1 }, 2)]
        [TestCase(new int[6] { 8, 4, 55, -87, 0, 2 }, 3)]
        public void GetIndexOfMinimalElementTest(int[] array, int expected)
        {
            int actual = Arrays.GetIndexOfMinimalElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 2, 5, 44, -10 }, 3)]
        [TestCase(new int[4] { 0, 55, -45, 100 }, 3)]
        [TestCase(new int[3] { 5, 8, 1 }, 1)]
        [TestCase(new int[6] { 8, 4, 55, -87, 0, 2 }, 2)]
        public void GetIndexOfMaximalElementTest(int[] array, int expected)
        {
            int actual = Arrays.GetIndexOfMaximalElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 2, 5, 44, -10 }, 46)]
        [TestCase(new int[4] { 0, 55, -45, 100 }, 155)]
        [TestCase(new int[3] { 5, 8, 1 }, 8)]
        [TestCase(new int[6] { 8, 4, 55, -87, 0, 2 }, -81)]
        public void GetSumOfElementsWithOddIndexsTest(int[] array, int expected)
        {
            int actual = Arrays.GetSumOfElementsWithOddIndexs(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 2, 5, 44, -10 }, new int[5] { -10, 44, 5, 2, -1})]
        [TestCase(new int[4] { 0, 55, -45, 100 }, new int[4] { 100, -45, 55, 0 })]
        [TestCase(new int[3] { 5, 8, 1 }, new int[3] { 1, 8, 5 })]
        [TestCase(new int[6] { 8, 4, 55, -87, 0, 2 }, new int[6] { 2, 0, -87, 55, 4, 8})]
        public void ReversArrayTest(int[] array, int[] expected) 
        {
            int[] actual = Arrays.ReversArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 2, 5, 44, -10 }, 2)]
        [TestCase(new int[4] { 0, 55, -45, 100 }, 2)]
        [TestCase(new int[3] { 5, 8, 1 }, 2)]
        [TestCase(new int[6] { 8, 4, 55, -87, 0, 2 }, 2)]
        public void GetNumberOfOddElementsTest(int[] array, int expected)
        {
            int actual = Arrays.GetNumberOfOddElements(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 2, 5, 44, -10 }, new int[5] { 44, -10, 5, -1, 2 })]
        [TestCase(new int[4] { 0, 55, -45, 100 }, new int[4] { -45, 100, 0, 55 })]
        [TestCase(new int[3] { 5, 8, 1 }, new int[3] { 1, 8, 5 })]
        [TestCase(new int[6] { 8, 4, 55, -87, 0, 2 }, new int[6] { -87, 0, 2, 8, 4, 55 })]
        public void SwapHalfsOfArrayTest(int[] array, int[] expected)
        {
            int[] actual = Arrays.SwapHalfsOfArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 2, 5, 44, -10 }, new int[5] { -10, -1, 2, 5, 44})]
        [TestCase(new int[4] { 0, 55, -45, 100 }, new int[4] { -45, 0, 55, 100})]
        [TestCase(new int[3] { 5, 8, 1 }, new int[3] { 1, 5, 8})]
        [TestCase(new int[6] { 8, 4, 55, -87, 0, 2 }, new int[6] { -87, 0, 2, 4, 8, 55 })]
        public void SortArrayInAscendingOrderTest(int[] a, int[] expected)
        {
            int[] actual = Arrays.SortArrayInAscendingOrder(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 2, 5, 44, -10 }, new int[5] { 44, 5, 2, -1, -10})]
        [TestCase(new int[4] { 0, 55, -45, 100 }, new int[4] { 100, 55, 0, -45 })]
        [TestCase(new int[3] { 5, 8, 1 }, new int[3] { 8, 5, 1 })]
        [TestCase(new int[6] { 8, 4, 55, -87, 0, 2 }, new int[6] { 55, 8, 4, 2, 0, -87 })]
        public void SortArrayInDescendingOrderTest(int[] a, int[] expected)
        {
            int[] actual = Arrays.SortArrayInDescendingOrder(a);
            Assert.AreEqual(expected, actual);
        }

    }
}
