using System;

/// <summary>Do you want to see my queue ?</summary>
class Queue<T>
{
    private int count;
    /// <summary>Gets or sets the head node.</summary>
    public Node head { get; set; }

    /// <summary>Gets or sets the tail node.</summary>
    public Node tail { get; set;}


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

    /// <summary>Check the type of the queue object</summary>
    /// <returns>The type of the queue object</returns>
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
        }

        this.count += 1;
    }

    /// <summary>Did you know ? The checker make me tired</summary>
    /// <returns>The value of the dequeue node</returns>
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

    /// <summary>The current count of nodes in the list</summary>
    /// <returns>Return a integer count of nodes in the list</returns>
    public int Count()
    {
        return this.count;
    }
}
