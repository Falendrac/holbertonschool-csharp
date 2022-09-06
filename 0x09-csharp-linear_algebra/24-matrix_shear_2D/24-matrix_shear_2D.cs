using System;

/// <summary>All methods for Matrix</summary>
class MatrixMath
{
    /// <summary>shears a square 2D matrix by a given shear factor and returns the resulting matrix.</summary>
    /// <param name="matrix">The matrix to shear</param>
    /// <param name="direction">The direction to shear</param>
    /// <param name="factor">Factor to multiply the matrix</param>
    /// <returns>
    /// If the matrix is of an invalid size, return a matrix containing -1
    /// If given an axis that is not x or y, return a matrix containing -1
    /// Otherwise, return the new matrix
    /// </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2
            || (direction != 'x' && direction != 'y'))
            return new double[,] {{ -1 }};

        double[,] newMatrix = new double[2, 2];

        for (int row = 0; row < 2; row++)
        {
            for (int column = 0; column < 2; column++)
            {
                if (direction == 'x' && column == 0)
                {
                    newMatrix[row, column + 1] = matrix[row, column + 1];
                    newMatrix[row, column] = matrix[row, column] + factor * matrix[row, column + 1];
                }
                if (direction == 'y' && column == 1)
                {
                    newMatrix[row, column - 1] = matrix[row, column - 1];
                    newMatrix[row, column] = matrix[row, column] + factor * matrix[row, column - 1];
                }
            }
        }

        return newMatrix;
    }
}
