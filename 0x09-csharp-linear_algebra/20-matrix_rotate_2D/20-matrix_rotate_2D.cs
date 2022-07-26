﻿using System;

/// <summary>All methods for Matrix</summary>
class MatrixMath
{
    /// <summary>rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.</summary>
    /// <param name="matrix">The matrix to rotate</param>
    /// <param name="angle">The angle of rotation</param>
    /// <returns>
    /// If the matrices cannot be multiplied, return a matrix containing -1
    /// Otherwise return the new matrix
    /// </returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(1) > 2)
            return new double[,] {{ -1 }};

        double[,] newMatrix = new double[2, 2];
        double[,] matrixRotation = new double[2, 2] {   {Math.Cos(angle), -Math.Sin(angle)},
                                                        {Math.Sin(angle), Math.Cos(angle)}
                                                    };

        for (int row = 0; row < 2; row++)
        {
            for (int column = 0; column < 2; column++)
            {
                for (int index = 0; index < 2; index++)
                {
                    newMatrix[row, column] = Math.Round((newMatrix[row, column] + (matrix[row, index] * matrixRotation[column, index])), 2);
                }
            }
        }

        return newMatrix;
    }
}
