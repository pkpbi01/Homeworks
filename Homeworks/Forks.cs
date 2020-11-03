using System;

namespace Homeworks
{
    static public class Forks
    {
        static public int PerformsTheCalculationDependingOnTheComparison(int a, int b)
        {
            int c = 0;
            if (a > b)
            {
                c = a + b;
            }
            else if (a < b)
            {
                c = a - b;
            }
            else
            {
                c = a * b;
            }
            return c;
        }

        static public int OutputTheNumberOfTheQuarterOfTheCoordinateAxis(int x, int y)
        {
            int result = 0;
            if (x > 0)
            {
                if (y > 0)
                {
                    result = 1;
                }
                else
                {
                    result = 2;
                }
            }
            else
            {
                if (y > 0)
                {
                    result = 4;
                }
                else
                {
                    result = 3;
                }
            }
            return result;
        }

        static public int[] SortingOfThreeNumbers(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                if (b < c)
                {
                    int[] result = { a, b, c };
                    return result;
                }
                else
                {
                    int[] result = { a, c, b };
                    return result;
                }
            }
            else if (b < a && b < c)
            {
                if (a < c)
                {
                    int[] result = { b, a, c };
                    return result;
                }
                else
                {
                    int[] result = { b, c, a };
                    return result;
                }
            }
            else
            {
                if (b < a)
                {
                    int[] result = { c, b, a };
                    return result;
                }
                else
                {
                    int[] result = { c, a, b };
                    return result;
                }
            }


        }

        static public double[] SolvesTheQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Error, a can't be equal to 0");
            }
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                double x1 = ((-b + Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(d)) / (2 * a));
                double[] result = new double[2] { x1, x2 };
                return result;
            }
            else if (d == 0)
            {
                double x1 = (-b / (2 * a));
                double[] result = new double[1] { x1 };
                return result;
            }
            else
            {
                double[] result = new double[0];
                return result;
            }
        }

        static public string ReturnsAnUppercaseEntryOfATwoDigitNumber(int number)
        {
            string firstWord = "";
            string secondWord = "";
            switch (number / 10)
            {
                case 1:
                    switch (number % 10)
                    {
                        case 0:
                            firstWord = "десять";
                            break;
                        case 1:
                            firstWord = "одинадцать";
                            break;
                        case 2:
                            firstWord = "двенадцать";
                            break;
                        case 3:
                            firstWord = "тринадцать";
                            break;
                        case 4:
                            firstWord = "четырнадцать";
                            break;
                        case 5:
                            firstWord = "пятьнадцать";
                            break;
                        case 6:
                            firstWord = "шестьнадцать";
                            break;
                        case 7:
                            firstWord = "семьнадцать";
                            break;
                        case 8:
                            firstWord = "восемьнадцать";
                            break;
                        case 9:
                            firstWord = "девятнадцать ";
                            break;
                    }
                    return firstWord;
                case 2:
                    firstWord = "двадцать ";
                    break;
                case 3:
                    firstWord = "тридцать ";
                    break;
                case 4:
                    firstWord = "сорок ";
                    break;
                case 5:
                    firstWord = "пятьдесят ";
                    break;
                case 6:
                    firstWord = "шестьдесят ";
                    break;
                case 7:
                    firstWord = "семьдесят ";
                    break;
                case 8:
                    firstWord = "восемьдесят ";
                    break;
                case 9:
                    firstWord = "девяносто ";
                    break;
            }
            switch (number % 10)
            {
                case 2:
                    secondWord = "два";
                    break;
                case 3:
                    secondWord = "три";
                    break;
                case 4:
                    secondWord = "четыре";
                    break;
                case 5:
                    secondWord = "пять";
                    break;
                case 6:
                    secondWord = "шесть";
                    break;
                case 7:
                    secondWord = "семь";
                    break;
                case 8:
                    secondWord = "восемь";
                    break;
                case 9:
                    secondWord = "девять";
                    break;
            }
            string result = firstWord + secondWord;
            return result;
        }
    }
}
