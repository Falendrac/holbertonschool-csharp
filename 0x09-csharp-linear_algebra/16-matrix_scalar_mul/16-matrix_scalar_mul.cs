using System;

/// <summary>All methods for Matrix</summary>
class MatrixMath
{
    /// <summary>multiplies a matrix and a scalar and returns the resulting matrix</summary>
    /// <param name="matrix">The matrix to multiply</param>
    /// <param name="scalar">The scalar</param>
    /// <returns>
    /// If the matrix is not a 2D or 3D matrix, return a matrix containing -1
    /// Otherwise return the new matrix
    /// </returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3
            || matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
            return new double[,] {{ -1 }};

        double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
                newMatrix[row, column] = matrix[row, column] * scalar;
        }

        return newMatrix;
    }
}
