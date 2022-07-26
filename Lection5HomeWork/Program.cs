using System;
using HelperLibrary;


namespace Lection5HomeWork
{
    public class Program
    {


        public static void Main(string[] args)
        {
            ;
            MatrixHelper.PrintMatrix(MatrixHelper.FlippedArrayAboutItsMainDiagonal(MatrixHelper.GenerateMatrix(3)));
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
