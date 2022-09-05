using System;

/// <summary>All methods for Matrix</summary>
class MatrixMath
{
    /// <summary> multiplies two matrices and returns the resulting matrix</summary>
    /// <param name="matrix1">First matrix</param>
    /// <param name="matrix2">Second matrix</param>
    /// <returns>
    /// If the matrices cannot be multiplied, return a matrix containing -1
    /// Otherwise return the new matrix
    /// </returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] {{ -1 }};

        double[,] newMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        double tmp = 0;

        for (int row1 = 0; row1 < matrix1.GetLength(0); row1++)
        {
            for (int column2 = 0; column2 < matrix2.GetLength(1); column2++)
            {
                tmp = 0;
                for (int rowColumn = 0; rowColumn < matrix1.GetLength(1); rowColumn++)
                    tmp += matrix1[row1, rowColumn] * matrix2[rowColumn, column2];
                newMatrix[row1, column2] = tmp;
            }
        }

        return newMatrix;
    }
}
