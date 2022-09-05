using System;

/// <summary>All methods for Vector</summary>
class VectorMath
{
    /// <summary>multiplies a vector and a scalar and returns the resulting vector</summary>
    /// <param name="vector">Vector to multiply with scalar</param>
    /// <param name="scalar">The scalar for multiply vector</param>
    /// <returns>
    /// If any vector is not a 2D or 3D vector, return a vector containing -1
    /// Otherwise return the new vector
    /// </returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return new double[1] { -1 };

        double[] newVector = new double[vector.Length];

        for (int browse = 0; browse < vector.Length; browse++)
            newVector[browse] = vector[browse] * scalar;

        return newVector;
    }
}
