using System;

namespace Lection5HomeWork
{
    class Program
    {
        static int MinMatrixElem(int[,] matrix)
        {
            (int minR, int minC) = MinMatrixIndexElem(matrix);
            return matrix[minR, minC];
        }

        static int MaxMatrixElem(int[,] matrix)
        {
            (int maxR, int maxC) = MaxMatrixIndexElem(matrix);
            return matrix[maxR, maxC];
        }

        static (int,int) MinMatrixIndexElem(int[,] matrix)
        {

            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Array null or empty");
            }

            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[minI, minJ] > matrix[i, j])
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }
            return (minI, minJ);
        }

        static (int,int) MaxMatrixIndexElem(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Array null or empty");
            }

            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[maxI, maxJ] < matrix[i, j])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
            return (maxI, maxJ);
        }

        //5.	Find the number of array elements that are greater than all their neighbors at the same time
        //static int GreaterElementOfMatrixArray(int[,] matrix)
        //{
        //    if (matrix == null || matrix.Length == 0)
        //    {
        //        throw new ArgumentException("Array null or empty");
        //    }

        //    int targetI = 0;
        //    int greatNumber = 0;
        //    int targetJ = 0;
        //    int sumI = 0;
        //    int sumJ = 0;

        //    int[] position = new int[matrix.GetLength(0) * matrix.GetLength(1)];

        //    while (greatNumber == 0)
        //    {
        //        for (int i = 0; i < matrix.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < matrix.GetLength(1); j++)
        //            {
        //                greatNumber = matrix[i, j];
        //                if(i == 0 && j == 0)
        //                {
        //                    sumI = matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i, j + 1];
        //                }
        //                else if(i != 0 && j == 0)
        //                {
        //                    sumI = matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i, j + 1];
        //                }
        //            }
        //        }
        //    }


        //    return targetI;
        //}

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
            Console.WriteLine();
            Console.WriteLine(GreaterElementOfMatrixArray(arr));
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
