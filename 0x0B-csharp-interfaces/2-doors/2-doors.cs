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
/// Door class, that define what's a door
/// </summary>
class Door: Base, IInteractive
{
    /// <summary>
    /// Constructor of door assign a name for this
    /// </summary>
    /// <param name="name">Name wanted for door, the default value of the name is "Door"</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interact with door. But it's locked.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}
