using System;

/// <summary>All methods for Matrix</summary>
class MatrixMath
{
    /// <summary>calculates the determinant of a matrix.</summary>
    /// <param name="matrix">The matrix where we calculate the determinant</param>
    /// <returns>
    /// If the matrix is not 2D or 3D, return -1
    /// Otherwise, return the determinant
    /// </returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2
            || matrix.GetLength(0) < 3 || matrix.GetLength(1) < 3)
            return -1;

        double determinant = 0;
        double tmp = 1;
        int diag = 0;

        for (int column = 0; column < matrix.GetLength(0); column++)
        {
            tmp = 1;
            diag = 0;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                if (column + row < matrix.GetLength(1))
                    tmp *= matrix[row, column + row];
                else
                {
                    tmp *= matrix[row, 0 + diag];
                    diag++;
                }
            }
            determinant += tmp;
        }

        for (int column = matrix.GetLength(0) - 1; column >= 0 ; column--)
        {
            tmp = 1;
            diag = 0;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                if (column - row >= 0)
                    tmp *= matrix[row, column - row];
                else
                {
                    tmp *= matrix[row, 2 - diag];
                    diag++;
                }
            }
            determinant -= tmp;
        }

        return determinant;
    }
}
