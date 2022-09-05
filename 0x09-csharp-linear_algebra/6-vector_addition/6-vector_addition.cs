using System;

/// <summary>All methods for Vector</summary>
class VectorMath
{
    /// <summary>adds two vectors and returns the resulting vector</summary>
    /// <param name="vector1">First vector to add<param>
    /// <param name="vector2">"Second vector to add<param>
    /// <returns>
    /// If any vector is not a 2D or 3D vector, or if the vectors are not of the same size, return a vector containing -1
    /// Otherwise return the vector
    /// </returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3
            || vector1.Length != vector2.Length)
            return new double[1] { -1 };

        double[] newVector = new double[vector1.Length];

        for (int browse = 0; browse < vector1.Length; browse++)
            newVector[browse] = vector1[browse] + vector2[browse];

        return newVector;
    }
}
