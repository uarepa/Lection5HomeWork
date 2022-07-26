using System;

namespace HelperLibrary
{
    public class MatrixHelper
    {

         public static int[,] GenerateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = count;
                    count++;
                }
            }
            return matrix;
        }
        public static int[,] GenerateMatrix(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                throw new ArgumentException();
            }

            Random random = new Random();
            int[,] matrix = new int[x, y];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, x * y);
                }
            }

            return matrix;
        }

        public static int[,] ReverseMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0, count = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) && count < matrix.Length / 2; j++, count++)
                {
                    LinearEquations.Swap(ref matrix[i, j], ref matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - 1 - j]);
                }
            }

            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        public static int MinMatrixElem(int[,] matrix)
        {
            (int minR, int minC) = MinMatrixIndexElem(matrix);

            return matrix[minR, minC];
        }

        public static int MaxMatrixElem(int[,] matrix)
        {
            (int maxR, int maxC) = MaxMatrixIndexElem(matrix);

            return matrix[maxR, maxC];
        }

       public static (int, int) MinMatrixIndexElem(int[,] matrix)
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

        public static (int, int) MaxMatrixIndexElem(int[,] matrix)
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

        public static int[,] FlippedArrayAboutItsMainDiagonal(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1) || matrix.Length == 0)
            {
                throw new ArgumentException();
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] flippedArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(i != j)
                    {
                        flippedArray[i, j] = matrix[rows - 1 - i, cols - 1 - j];
                    }
                    else
                    {
                        flippedArray[i, j] = matrix[i, j];
                    }
                }
            }

            return flippedArray;
        }

        public static int TheNumberThatAreGreatedThanAllNeighbors(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix");
            }

            int biggestnumber = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int tempnumber = 0;

                    for (int iInternal = i - 1; iInternal <= i + 1; iInternal++)
                    {
                        if (iInternal >= 0 && iInternal <= matrix.GetLength(0) - 1)
                        {
                            for (int jInternal = j - 1; jInternal <= j + 1; jInternal++)
                            {
                                if (jInternal >= 0 && jInternal <= matrix.GetLength(1) - 1 && (iInternal != i || jInternal != j))
                                {
                                    if(tempnumber < matrix[iInternal, jInternal])
                                    {
                                        tempnumber = matrix[iInternal, jInternal];
                                    }
                                }
                            }
                        }
                    }

                    if(matrix[i,j] > tempnumber)
                    {
                        biggestnumber++;
                    }
                }
            }

            return biggestnumber;
        }
    }
}
