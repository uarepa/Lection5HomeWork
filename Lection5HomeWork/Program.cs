using System;

namespace Lection5HomeWork
{
    class Program
    {

        static int MinMatrixElem(int[,] matrix)
        {

            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Array null or empty");
            }

            int minMatrixElement = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {

                }
            }
            return minMatrixElement;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[9];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
            }
            PrintArray(arr);
        }

        #region Utils
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        #endregion
    }
}
