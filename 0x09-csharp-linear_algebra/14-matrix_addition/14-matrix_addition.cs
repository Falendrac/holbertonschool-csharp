using System;

/// <summary>All methods for Matrix</summary>
class MatrixMath
{
    /// <summary>adds two matrices and returns the resulting matrix</summary>
    /// <param name="matrix1">First matrix</param>
    /// <param name="matrix2">Second matrix</param>
    /// <returns>
    /// If any matrix is not a 2D or 3D matrix, or both matrices are not the same size, return a matrix containing -1
    /// Otherwise return the new matrix
    /// </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3
            || matrix1.GetLength(1) < 2 || matrix1.GetLength(1) > 3
            || matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3
            || matrix2.GetLength(1) < 2 || matrix2.GetLength(1) > 3
            || matrix1.Length != matrix2.Length)
            return new double[,] {{ -1 }};

        double[,] newMatrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int row = 0; row < matrix1.GetLength(0); row++)
        {
            for (int column = 0; column < matrix1.GetLength(1); column++)
                newMatrix[row, column] = matrix1[row, column] + matrix2[row, column];
        }

        return newMatrix;
    }
}
