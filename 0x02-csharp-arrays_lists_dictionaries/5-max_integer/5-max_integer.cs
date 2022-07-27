using System;
using System.Collections.Generic;

class List
{
    // Finds the biggest integer in a list
    // @myList: The list to find the biggest integer
    // Return: -1 if the list is empty, otherwise the biggest integer
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int maxInt = myList[0];

        foreach (var element in myList)
        {
            if (maxInt < element)
            {
                maxInt = element;
            }
        }

        return maxInt;
    }
}
