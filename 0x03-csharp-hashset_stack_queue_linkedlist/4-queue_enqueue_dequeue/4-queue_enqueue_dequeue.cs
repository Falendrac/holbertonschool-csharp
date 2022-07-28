using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int countItems = 0, index = 0;
        string topItem = "";
        bool findSearch = false, firstItem = false;

        foreach (string element in aQueue)
        {
            countItems++;

            if (element == search)
            {
                findSearch = true;
                index = countItems;
            }

            if (!firstItem)
            {
                topItem = element;
                firstItem = true;
            }
        }

        if (findSearch)
        {
            for (int loop = 0; loop < index; loop++)
                aQueue.Dequeue();
        }

        aQueue.Enqueue(newItem);

        Console.WriteLine("Number of items: {0}", countItems);

        if (countItems == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", topItem);

        Console.WriteLine("Queue contains \"{0}\": {1}", search, findSearch);

        return aQueue;
    }
}
