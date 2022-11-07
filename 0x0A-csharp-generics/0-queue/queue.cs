using System;

/// <summary>Do you want to see my queue ?</summary>
class Queue<T>
{
    /// <summary>Check the type of the queue object</summary>
    /// <returns>The type of the queue object</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
