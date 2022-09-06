using System;

/// <summary>All methods for Matrix</summary>
class MatrixMath
{
    /// <summary>transpose a matrix and return the resulting matrix.</summary>
    /// <param name="matrix">The matrix to transpose</param>
    /// <returns>
    /// If the matrix is empty, return an empty matrix
    /// Otherwise, return the new matrix
    /// </returns>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return new double[0, 0];

        double[,] newMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                newMatrix[column, row] = matrix[row, column];
            }
        }

        return newMatrix;
    }
}
