using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    static public class Arrays
    {
        static public int[] CopyArray(int[] array)
        {
            int[] a = new int[array.Length];
            Array.Copy(array, a, array.Length);
            return a;
        }

        static public int GetMinimalElement(int[] array)
        {
            int minimum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                }
            }
            return minimum;
        }

        static public int GetMaximalElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static public int GetIndexOfMinimalElement(int[] array)
        {
            int minimum = array[0];
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        static public int GetIndexOfMaximalElement(int[] array)
        {
            int maximal = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maximal)
                {
                    maximal = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static public int GetSumOfElementsWithOddIndexs(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        static public int[] ReversArray(int[] array)
        {
            int[] a = CopyArray(array);
            for (int i = 0; i < a.Length / 2; i++)
            {
                int t = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = t;
            }
            return a;
        }

        static public int GetNumberOfOddElements(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        static public int[] SwapHalfsOfArray(int[] a)
        {
            int[] array = CopyArray(a);
            int[] supportArray = new int[(array.Length + 1 / 2)];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < (array.Length) / 2)
                {
                    supportArray[i] = array[i];
                    array[i] = array[i + (array.Length + 1) / 2];
                }
                else if (i >= (array.Length + 1) / 2)
                {
                    array[i] = supportArray[i - ((array.Length + 1) / 2)];
                }
            }
            return array;
        }

        static public int[] SortArrayInAscendingOrder(int[] a)
        {
            int[] array = CopyArray(a);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
            }
            return array;
        }

        static public int[] SortArrayInDescendingOrder(int[] a)
        {
            int[] array = CopyArray(a);
            int minimum = array[0];
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int chandger = array[minIndex];
                array[minIndex] = array[i];
                array[i] = chandger;
            }
            return array;
        }
    }
}