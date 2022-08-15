using System;

/// <summary>Class object</summary>
class Obj
{
    /// <summary>Check if an object is an int</summary>
    /// <param name="obj">The object we check</param>
    /// <returns>True if the obj is an int, False otherwise</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
}
