using System;
using System.Collections.Generic;

class List
{
    // finds all multiples of 2 in a list
    // @myList: List of integer
    // Return: Null if myList is null, otherwise return list of bool
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            return null;
        }

        var result = new List<bool>();

        foreach (var element in myList)
        {
            result.Add(element % 2 == 0);
        }

        return result;
    }
}
