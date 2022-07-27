using System;
using System.Collections.Generic;

class List
{
    // Create a new list with the size given in parameter and fill
    // the list of integer starting by 0 and engin by size - 1
    // @size: The size of the new list
    // Return: null if size is negative, otherwise return the new list
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        var newList = new List<int>();

        for (int loop = 0; loop < size; loop++)
        {
            newList.Add(loop);
            Console.Write(loop);
            if (loop < size - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();

        return newList;
    }
}
