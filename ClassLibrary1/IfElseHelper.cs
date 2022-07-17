using System;

namespace HelperLibrary
{
    class IfElseHelper
    {

        public static int Condition(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        public static int CoordinateQuarter(int x, int y)
        {
            int result = 0;
            if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x > 0 && y < 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else
            {
                result = 4;
            }

            return result;
        }

        public static (int a, int b, int c) FromLowToHigh(int a, int b, int c)
        {

            if (a > b)
            {
                HelperLibrary.LinearEquations.Swap(ref a, ref b);
            }
            else if (a > c)
            {
                HelperLibrary.LinearEquations.Swap(ref a, ref c);
            }
            else if (b > c)
            {
                HelperLibrary.LinearEquations.Swap(ref b, ref c);
            }

            return (a, b, c);
        }

        public static (double x1, double x2) RootOfQuadraticEquation(double a, double b, double c)
        {
            double x1 = double.NaN;
            double x2 = double.NaN;
            double d = b * b - 4 * a * c;

            if (a == 0 || d < 0)
            {
                throw new DivideByZeroException();
            }

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d) / (2 * a));
                x2 = (-b - Math.Sqrt(d) / (2 * a));
            }
            else if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
            }

            return (x1, x2);
        }

        public static string NumberToWords(int number)
        {
            if (number < 10 || number > 99)
            {
                throw new ArgumentOutOfRangeException();
            }

            string words = "";
            string[] simpleNumberMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensNumberMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number == 0)
            {
                words += simpleNumberMap[0];
                return words;
            }

            if (number > 0)
            {
                if (number < 20)
                {
                    words += simpleNumberMap[number];
                }
                else
                {
                    words += tensNumberMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + simpleNumberMap[number % 10];
                }
            }

            return words;

        }
    }
}
