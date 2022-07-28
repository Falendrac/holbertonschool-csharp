using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        string topItem = "";
        bool findSearch = false, firstItem = false;
        int count = 0, index = 0;

        foreach (string str in aStack)
        {
            count += 1;
            if (firstItem == false)
            {
                topItem = str;
                firstItem = true;
            }

            if (str == search)
            {
                findSearch = true;
                index = count;
            }
        }

        if (findSearch == true)
        {
            for (int i = 0; i < index; i++)
                aStack.Pop();
        }
        aStack.Push(newItem);
        Console.WriteLine("Number of items: {0}", count);

        if (count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", topItem);

        Console.WriteLine("Stack contains \"{0}\": {1}", search, findSearch);

        return (aStack);
    }
}
