using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int countItems = 0, index = 0;
        string topItem = "";
        bool findSearch = false, firstItem = false;

        foreach (string element in aStack)
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
                aStack.Pop();
        }

        aStack.Push(newItem);

        Console.WriteLine("Number of items: {0}", countItems);

        if (countItems == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", topItem);

        Console.WriteLine("Stack contains \"{0}\": {1}", search, findSearch);

        return aStack;
    }
}
