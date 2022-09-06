using System;

/// <summary>All methods for Matrix</summary>
class MatrixMath
{
    /// <summary>calculates the inverse of a 2D matrix and returns the resulting matrix</summary>
    /// <param name="matrix">Neo is here</param>
    /// <returns>
    /// If the matrix is not a 2D matrix, return [-1]
    /// If the matrix is non-invertible, return [-1]
    /// Otherwise, return the new vector
    /// </returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2
            || matrix[0, 0] * matrix[1, 1] - matrix[0,1] * matrix[1, 0] == 0)
            return new double[,] {{-1}};

        double[,] newMatrix = new double[,] {
                                                {matrix[1, 1], -matrix[0, 1]},
                                                {-matrix[1, 0], matrix[0, 0]}
        };
        double detNewMatrix = 1/(newMatrix[0, 0] * newMatrix[1, 1] - newMatrix[0,1] * newMatrix[1, 0]);

        newMatrix[0, 0] = Math.Round(detNewMatrix*newMatrix[0,0], 2);
        newMatrix[1, 1] = Math.Round(detNewMatrix*newMatrix[1,1], 2);
        newMatrix[0, 1] = Math.Round(detNewMatrix*newMatrix[0,1], 2);
        newMatrix[1, 0] = Math.Round(detNewMatrix*newMatrix[1,0], 2);

        return newMatrix;
    }
}
