using System;

/// <summary>
/// Base is a abstract class that can be define by user
/// </summary>
abstract class Base
{
    /// <summary>Get or set name</summary>
    public string name { get; set; }

    /// <summary>String representation of the class</summary>
    /// <return>{name} is a {Type of the object}</return>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, this.GetType());
    }
}

/// <summary>IInteractive interface</summary>
public interface IInteractive
{
    /// <summary>Interact method</summary>
    void Interact();
}

/// <summary>IBreakable interface</summary>
public interface IBreakable
{
    /// <summary>Get or set durability</summary>
    int durability { get; set; }

    /// <summary>Break method</summary>
    void Break();
}

/// <summary>ICollectable interface</summary>
public interface ICollectable
{
    /// <summary>Get or set isCollected</summary>
    bool isCollected { get; set; }

    /// <summary>Collect method</summary>
    void Collect();
}

/// <summary>
/// TestObject class that inherits of Base and 3 interfaces
/// </summary>
class TestObject: Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>Get or set durability</summary>
    public int durability { get; set; }
    /// <summary>Get or set isCollected</summary>
    public bool isCollected { get; set; }

    /// <summary>Interact method</summary>
    public void Interact()
    {}

    /// <summary>Break method</summary>
    public void Break()
    {}

    /// <summary>Collect method</summary>
    public void Collect()
    {}
}
