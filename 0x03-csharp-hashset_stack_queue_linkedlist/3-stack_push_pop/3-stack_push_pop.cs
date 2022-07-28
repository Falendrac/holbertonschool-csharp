﻿using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int countItems = aStack.Count;

        Console.WriteLine("Number of items: {0}", countItems);

        if (countItems == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());

        if (true)
        {
            Console.WriteLine("Stack contains {0}: {1}", search, aStack.Contains(search));

            while (aStack.Peek() != search)
                aStack.Pop();
            aStack.Pop();
        }

        aStack.Push(newItem);

        return aStack;
    }
}
