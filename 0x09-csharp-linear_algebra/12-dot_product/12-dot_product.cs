using System;

/// <summary>All methods for Vector</summary>
class VectorMath
{
    /// <summary>calculates dot product of either two 2D or two 3D vectors.</summary>
    /// <param name="vector1">First vector</param>
    /// <param name="vector2">Second vector</param>
    /// <returns>
    /// If any vector is not a 2D or 3D vector, or both vectors are not the same size, return -1
    /// Otherwise return the dot product
    /// </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3
            || vector1.Length != vector2.Length)
            return -1;

        double result = 0;

        for (int browse = 0; browse < vector1.Length; browse++)
            result += vector1[browse] * vector2[browse];

        return result;
    }
}
