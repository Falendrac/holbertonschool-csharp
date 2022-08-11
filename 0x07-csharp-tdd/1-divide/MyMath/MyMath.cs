using System;

namespace MyMath
{
    /// <summary>Define some basics mathematics operations</summary>
    public class Matrix
    {
        /// <summary>Divide a matrix by num</summary>
        /// <param name="matrix">The Matrix to divide</param>
        /// <param name="num">The number for division</param>
        /// <returns>A new matrix or Null if it fail</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            int[,] newMatrix = matrix;

            try
            {
                for (int loop1 = 0; loop1 < matrix.GetLength(0); loop1++)
                {
                    for (int loop2 = 0; loop2 < matrix.GetLength(1); loop2++)
                    {
                        newMatrix[loop1, loop2] = matrix[loop1, loop2] / num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            return newMatrix;
        }
    }
}
