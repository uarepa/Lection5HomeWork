using System;

namespace HelperLibrary
{
    public class ArrayHelper
    {

        public static void PrintArray(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
            }

            Console.WriteLine();
        }

        public static int[] RandomArray(int a)
        {
            if( a < 0)
            {
                throw new ArgumentException();
            }

            int size = a;

            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
            }

            return array;
        }

        public static void Sort(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        LinearEquations.Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        public static int MinElementOfArray(int[] array)
        {
            return array[MinIndexOfArray(array)];
        }

        public static int MaxElementOfArray(int[] array)
        {
            return array[MaxIndexOfArray(array)];
        }

        public static int MinIndexOfArray(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentException();
            }

            int minI = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < array[minI])
                {
                    minI = i;
                }
            }

            return minI;
        }

        public static int MaxIndexOfArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int maxI = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxI])
                {
                    maxI = i;
                }
            }

            return maxI;
        }

        public static int SumOddIndexes(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int sum = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int[] ReversedArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int count = 1;
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[array.Length - count];
                count++;
            }

            return newArray;
        }

        public static int CountOddElements(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] SwapArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int halfArray = array.Length - array.Length / 2;

            for (int i = 0; i < halfArray; i++)
            {
                LinearEquations.Swap(ref array[i], ref array[halfArray]);
                halfArray++;
            }

            return array;
        }
    }
}
