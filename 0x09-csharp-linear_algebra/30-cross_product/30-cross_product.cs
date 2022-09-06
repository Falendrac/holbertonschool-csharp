using System;

/// <summary>All methods for Matrix</summary>
class MatrixMath
{
    /// <summary>calculates the cross product of two 3D vectors and returns the resulting vector.</summary>
    /// <param name="vector1">first vector</param>
    /// <param name="vector2">Second vector</param>
    /// <returns>
    /// If either vector is not a 3D vector, return a vector containing -1
    /// Otherwise, return the new vector
    /// </returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1};

        double[] newVector = new double[vector1.Length];

        // Do you know "la flemme" ?
        newVector[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        newVector[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        newVector[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return newVector;
    }
}
