using System;

/// <summary>
/// Generic Queue class
/// </summary>
class Queue<T>
{
    private int count;

    /// <summary>Gets or sets the head node.</summary>
    public Node head { get; set; }

    /// <summary>Gets or sets the tail node.</summary>
    public Node tail { get; set; }

    /// <summary>Gets or sets a temporary node.</summary>
    private Node temp { get; set; }


    /// <summary>
    /// Represent some generics nodes.
    /// </summary>
    public class Node
    {
        /// <summary>Gets or sets the next node.</summary>
        public Node next { get; set; }

        /// <summary>Gets or sets the node value.</summary>
        public T value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="TValue">node value</param>
        public Node(T TValue)
        {
            this.value = TValue;
        }
    }

    /// <summary>
    /// Check type of T.
    /// </summary>
    /// <returns>Queue's type</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }

    /// <summary>
    /// Creates a new Node and adds it to the end of the queue.
    /// </summary>
    /// <param name="TValue">Generic value of the node</param>
    public void Enqueue(T TValue)
    {
        Node temp = new Node(TValue);

        if (count == 0)
        {
            tail = temp;
            head = temp;
        }
        else
        {
            tail.next = temp;
            tail = temp;
        }

        this.count += 1;
    }

    /// <summary>
    /// Removes the first node in the queue.
    /// </summary>
    /// <returns>Value of the first node</returns>
    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            // default value
            return default(T);
        }

        T headValue = head.value;
        head = head.next;
        this.count -= 1;
        return headValue;
    }

    /// <summary>
    /// Peek the first node of the queue without removing it.
    /// </summary>
    /// <returns>Value of the first node</returns>
    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            // default value
            return default(T);
        }

        T headValue = head.value;
        return headValue;
    }

    public void Print()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        temp = head;

        while (temp != null)
        {
            Console.WriteLine(temp.value);
            temp = temp.next;
        }
    }

    /// <summary>
    /// Count the number of nodes.
    /// </summary>
    /// <returns>Number of nodes</returns>
    public int Count()
    {
        return this.count;
    }
}
