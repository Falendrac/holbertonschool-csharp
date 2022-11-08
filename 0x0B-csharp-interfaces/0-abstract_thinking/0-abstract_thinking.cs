using System;

/// <summary>
/// Base is a abstract class that can be define by user
/// </summary>
abstract class Base
{
    /// <summary>The name of a person</summary>
    public string name;

    /// <summary>String representation of the class</summary>
    /// <return>{name} is a {Type of the object}</return>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, this.GetType());
    }
}
