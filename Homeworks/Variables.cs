using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    static public class Variables
    {
        static public double DoMathProblem(double a, double b)
        {
            if (a == b)
            {
                throw new Exception("Error, a can't be equal to b");
            }
            double c = (a * 5 + b * b) / (b - a);
            return c;
        }

        static public int[] MakeTheResultOfTheDivisionAndRemainder(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Error, b can't be equal to 0");
            }
            int[] c = new int[2];
            c[0] = a / b;
            c[1] = a % b;
            return c;
        }

        static public double LookinForASolutionToTheEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Error, a can't be equal to 0");
            }
            double result = (c - b) / a;
            return result;
        }

        static public string FindTheEquationOfAStraightLineByPoints(double x1, double x2, double y1, double y2)
        {
            double aN = (y1 - y2) / (-(x2 - x1));
            double bN = (x1 * y2 - x2 * y1) / (-(x2 - x1));
            if ((x1 == x2) || (y1 == y2))
            {
                throw new Exception("Error, x1 can't be equal to x2 or y1 can't be equal to y2");
            }
            string a = Convert.ToString(aN);
            string b = Convert.ToString(bN);
            string equation;
            if (bN > 0)
            {
                equation = $"y = {a}x + {b}";
            }
            else if (bN < 0)
            {
                b = Convert.ToString(-(x1 * y2 - x2 * y1) / (-(x2 - x1)));
                equation = $"y = {a}x - {b}";
            }
            else
            {
                equation = $"y = {a}x";
            }
            return equation;
        }
    }
}