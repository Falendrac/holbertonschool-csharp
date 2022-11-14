using System;

/// <summary>
/// BaseClass for all class in the InventoryLibrary
/// </summary>
public class BaseClass
{
    /// <summary>Id of the instance</summary>
    public string id { get; set; }

    /// <summary>Date that instance was created</summary>
    public DateTime date_created { get; }

    /// <summary>Last date that istance was updated</summary>
    public DateTime date_updated;

    /// <summary>Constructor of BaseClass</summary>
    public BaseClass()
    {
        this.id = Guid.NewGuid().ToString();
        this.date_created = DateTime.Now;
        this.date_updated = this.date_created;
    }

    /// <summary>Update the <see cref="date_updated"/> when it was called</summary>
    public void Update()
    {
        this.date_updated = DateTime.Now;
    }
}
