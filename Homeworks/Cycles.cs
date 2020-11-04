using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    static public class Cycles
    {
        static public double RaiseToADegree(int number, int degree)
        {
            double result = 1;
            if (degree > 0)
            {
                for (int i = 0; i < degree; i++)
                {
                    result *= number;
                }
            }
            else
            {
                degree *= -1;
                for (int i = 0; i < degree; i++)
                {
                    result /= number;
                }
            }
            return result;
        }

        static public int[] ReturnNumbersDivisibleByN(int n)
        {
            int[] result = new int[(1000 / n)];
            int counter = 0;
            for (int i = 0; i <= 1000; i += n)
            {
                if (i % n == 0 && i != 0)
                {
                    
                    result[counter] = i;
                    counter++;
                }

            }
            return result;
        }

        static public int SearchForNumbersWhoseSquareIsLessThanN(int n)
        {
            int result = 0;
            for (int i = 1; i < n; i++)
            {
                if (i * i < n)
                {
                    result++;

                }
                else
                {
                    break;
                }
            }
            return result;
        }

        //------------------------------------------------------------------------------------------
        static public int ReturnTheLargestDivisor(int n)
        {
            if (n % 2 == 0)
            {
                return (n / 2);
            }
            else
            {
                for (int i = n - 2; n % (i + 1) != 0; i--)
                {
                    if (n % i == 0)
                    {
                        return i;
                    }
                }
            }
            return 1;
        }
        //------------------------------------------------------------------------------------------

        static public int CalculateTheSumOfNumbersDivisibleBySevenInTheRange(int a, int b)
        {
            int sum = 0;
            if (a > b)
            {
                sum = b;
                b = a;
                a = sum;
                sum = 0;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static public int ReturnTheNthTermOfTheFibonacciSeries(int n)
        {
            int firstnumber = 0;
            int secondnumber = 1;
            int sum = 0;
            if (n == 2)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i < n - 1; i++)
                {

                    sum = firstnumber + secondnumber;
                    firstnumber = secondnumber;
                    secondnumber = sum;
                }
                return sum;
            }
        }

        static public int FindTheGreatestCommonDivisor(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return (a + b);
        }

        static public int CalculateTheCubicRoot(int cube)
        {
            int center = 0;
            int leftEdge = 1;
            int rightEdge = cube / 2;
            int fcenter = 0;
            while (true)
            {
                center = (leftEdge + rightEdge) / 2;
                fcenter = center * center * center;
                if (fcenter < cube)
                {
                    leftEdge = center;
                }
                else
                {
                    rightEdge = center;
                }
                if (rightEdge - leftEdge <= 1)
                {
                    return (leftEdge + 1);
                }
            }
        }

        static public int FindTheNumberOfOddDigitsOfANumber(int n)
        {
            int counter = 0;
            while (n != 0)
            {
                if ((n % 10) % 2 != 0)
                {
                    counter++;
                }
                n = n / 10;
            }
            return counter;
        }

        static public int FindTheMirrorImageOfANumber(int n)
        {
            int reversN = 0;
            while (n != 0)
            {
                reversN *= 10;
                reversN += n % 10;
                n /= 10;
            }
            return reversN;
        }

        static public int ReturnTheNumberOfNumbersWhereTheSumOfEvenDigitsIsGreaterThanOdd(int n)
        {
            int counter = 0;
            int m = 0;
            int sumofEven = 0;
            int sumofOdd = 0;
            for (int i = 0; i <= n; i++)
            {
                m = i;
                sumofEven = 0;
                sumofOdd = 0;
                while (m != 0)
                {
                    if ((m % 10) % 2 == 0)
                    {
                        sumofEven += m % 10;
                    }
                    else
                    {
                        sumofOdd += m % 10;
                    }
                    m /= 10;
                }
                if (sumofEven > sumofOdd)
                {
                    counter++;
                }
            }

            return counter;
        }

        static public bool FindIfThereAreIdenticalDigitsInTwoNumbers(int a, int b)
        {
            int counter = 0;
            while (a != 0)
            {
                int ia = a % 10;
                int ib = b;
                while (ib != 0)
                {
                    if (ia == (ib % 10))
                    {
                        counter++;
                    }
                    ib /= 10;
                }
                a /= 10;
            }
            if (counter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
