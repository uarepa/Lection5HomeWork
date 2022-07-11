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
            int minMatrixElementx = 0;
            int minMatrixElementy = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[minMatrixElementx + i, minMatrixElementy + i] > matrix[i, j])
                    {
                        minMatrixElement = matrix[i, j];
                    }
                }
            }
            return minMatrixElement;
        }

        static int MaxMatrixElem(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Array null or empty");
            }

            int maxMatrixElement = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (maxMatrixElement < matrix[i, j])
                    {
                        maxMatrixElement = matrix[i, j];
                    }
                }
            }
            return maxMatrixElement;
        }

        static (int,int) MinMatrixIndexElem(int[,] matrix)
        {

            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Array null or empty");
            }

            int minMatrixIndexElementx = 0;
            int minMatrixIndexElementy = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[minMatrixIndexElementx, minMatrixIndexElementy] > matrix[i, j])
                    {
                        minMatrixIndexElementx = i;
                        minMatrixIndexElementy = j;
                    }
                }
            }
            return (minMatrixIndexElementx, minMatrixIndexElementy);
        }

        static (int,int) MaxMatrixIndexElem(int[,] matrix)
        {

            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Array null or empty");
            }

            int maxMatrixIndexElementx = 0;
            int maxMatrixIndexElementy = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[maxMatrixIndexElementx, maxMatrixIndexElementy] < matrix[i, j])
                    {
                        maxMatrixIndexElementx = i;
                        maxMatrixIndexElementy = j;
                    }
                }
            }
            return (maxMatrixIndexElementx, maxMatrixIndexElementy);
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] arr = new int[4,4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = random.Next(3, 15);
                }
                
            }
            PrintMatrixArray(arr);
            Console.WriteLine(MinMatrixIndexElem(arr));
            Console.WriteLine(MaxMatrixIndexElem(arr));
            Console.WriteLine(MinMatrixElem(arr));
            Console.WriteLine(MaxMatrixElem(arr));
        }

        #region Utils
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void PrintMatrixArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        #endregion
    }
}
