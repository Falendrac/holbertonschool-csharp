using System;

/// <summary>Class object</summary>
class Obj
{
    /// <summary>
    /// Check if an object is an instance of a class inherited of Array
    /// The object must be a subclass; the object is not an instance of the base class.
    /// </summary>
    /// <param name="derivedType">The derived type we check with baseType</param>
    /// <param name="baseType">The Base type for check</param>
    /// <returns>True if the obj is an instance of baseType, False otherwise</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
