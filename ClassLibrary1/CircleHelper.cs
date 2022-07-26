using System;

namespace HelperLibrary
{
    public class CircleHelper
    {

        public static double PowerOfNumber(double number, double powerOfnumber)
        {
            double result = 1;

            if (number == 0)
            {
                throw new ArgumentException();
            }

            if(powerOfnumber > 0)
            {
                for (int i = 1; i <= powerOfnumber; i++)
                {
                    result += number;
                }
            }
            else if(powerOfnumber < 0)
            {
                for (int i = -1; i >= powerOfnumber; i--)
                {
                    result /= number;
                }
            }

            return result;
        }

        public static int CountOfNumber(int a)
        {
            int i = 0;

            while ((i * i) < a)
            {
                i++;
            }

            return i - 1;
        }

        public static int LargestDivisor(int a)
        {
            int i;

            for (i = a - 1; i >= 1; --i)
            {
                if (a % i == 0) return i;
            }

            return 0;
        }

        public static int NumberOfFibonacciSeries(int a)
        {
            int first = 0;
            int second = 1;

            for (int i = 0; i < a; i++)
            {
                int temp = first;
                first = second;
                second += temp;
            }

            return first;
        }

        public static int Euclid(int a, int b)
        {
            int min = Math.Min(a, b);

            if(a % min == 0 && b % min == 0)
            {
                return min;
            }

            for (int i = min / 2; i >= 2; i--)
            {
                if(a % 1 == 0 && b % i == 0)
                {
                    return i;
                }
            }

            return 0;
        }

        public static int NumberOfOdd(int a)
        {
            int result = 0;

            do
            {
                if(((a % 10) % 2) != 0)
                {
                    result++;
                }
            }
            while((a /= 10) != 0);

            return result;
        }

        public static int ReverseNumber(int a)
        {
            int result = 0;

            while(a != 0)
            {
                int temp = a % 10;
                result = result * 10 + temp;
                a /= 10;
            }

            return result;
        }

        public static bool CheckDigits(int a, int b)
        {
            bool result = false;

            int temp = b;

            while(a != 0)
            {
                int tempA = a % 10;

                while(b != 0)
                {
                    int tempB = b % 10;

                    if(tempA == tempB)
                    {
                        return true;
                    }
                    b /= 10;
                }

                b = temp;
                a /= 10;
            }

            return result;
        }
    }
}
