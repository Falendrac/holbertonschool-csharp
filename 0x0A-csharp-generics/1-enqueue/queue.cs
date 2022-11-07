using System;

/// <summary>Do you want to see my queue ?</summary>
class Queue<T>
{
    /// <summary>Get and Set the head of a list</summary>
    public Node head { get; set; }
    /// <summary>Get and set the tail of a list</summary>
    public Node tail { get; set; }
    /// <summary>The count of the node in the list</summary>
    public int count;

    /// <summary>Check the type of the queue object</summary>
    /// <returns>The type of the queue object</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }

    /// <summary>Represent the node of a list</summary>
    public class Node
    {
        /// <summary>Get and Set the value of a node</summary>
        public T value { get; set; }
        /// <summary>Get and Set the next node of this node</summary>
        public Node next { get; set; }

        /// <summary>Constructor of the node</summary>
        /// <param name="newValue">Value of the node</param>
        public Node(T newValue)
        {
            this.value = newValue;
        }
    }

    /// <summary>Creates a new Node and adds it to the end of the queue.</summary>
    /// <param name="value">The value of the new node<param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (this.count == 0)
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
