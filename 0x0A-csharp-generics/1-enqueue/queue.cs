using System;

/// <summary>Do you want to see my queue ?</summary>
class Queue<T>
{
    private int count;

    /// <summary>Gets or sets the head node.</summary>
    public Node head { get; set; }

    /// <summary>Gets or sets the tail node.</summary>
    public Node tail { get; set;}


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

    /// <summary>Check the type of the queue object</summary>
    /// <returns>The type of the queue object</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }

    /// <summary>Creates a new Node and adds it to the end of the queue.</summary>
    /// <param name="value">The value of the new node<param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (count == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
        }

        this.count += 1;
    }

    /// <summary>The current count of nodes in the list</summary>
    /// <returns>Return a integer count of nodes in the list</returns>
    public int Count()
    {
        return this.count;
    }
}
