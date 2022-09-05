using System;

/// <summary>All methods for Vector</summary>
class VectorMath
{
    /// <summary>calculates and returns the length of a given vector.</summary>
    /// <param name="vector">The vector given we want to calculate<param>
    /// <returns>The length of a given vector, return -1 if is not a 2D or 3D vector</returns>
    public static double Magnitude(double[] vector)
    {
        double magnitude = 0;

        if (vector.Length < 2 || vector.Length > 3)
            return -1;

        foreach (var element in vector)
            magnitude += Math.Pow(element, 2);

        return Math.Round(Math.Sqrt(magnitude));
    }
}
