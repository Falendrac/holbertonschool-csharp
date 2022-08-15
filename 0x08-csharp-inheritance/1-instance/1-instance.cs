using System;

/// <summary>Class object</summary>
class Obj
{
    /// <summary>Check if an object is an instance of a class inherited of Array</summary>
    /// <param name="obj">The object we check</param>
    /// <returns>True if the obj is an instance of Array, False otherwise</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
