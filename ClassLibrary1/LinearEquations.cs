using System;

namespace HelperLibrary
{
    class LinearEquations
    {

        public static int CalculateMuntes(int hours)
        {
            if(hours <= 0)
            {
                throw new ArithmeticException();
            }

            return hours * 60;
        }

        public static double CalculateSolution(int a, int b)
        {
            if(b == a)
            {
                throw new DivideByZeroException();
            }

            return (5 * a + b * b) / (b - a);
        }

        public static (int a,int b) Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            return (a, b);
        }

        public static (int result, int divisionRemainder) CaluclateDivisionAndRemainderFormDivision(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException();
            }

            int result = a / b;
            int divisionRemainder = a % b;
            return (result, divisionRemainder);
        }

        public static float CalculateLinearEquation(int a, int b, int c)
        {
            if(a == 0)
            {
                throw new DivideByZeroException();
            }

            return (float)(c - b) / a;
        }

        public static (double a, double b) EquationOfLine(int x1, int y1, int x2, int y2)
        {
            if(x1 - x2 == 0)
            {
                throw new DivideByZeroException();
            }

            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;

            return (a, b);
        }

        public static int SumOfDigits(int number)
        {
            if( number < 10 || number > 99)
            {
                throw new ArgumentException();
            }

            return (number % 10) + (number / 10);
        }

    }
}
