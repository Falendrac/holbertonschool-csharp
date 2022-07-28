using System;
using System.Collections.Generic;

class List
{
    // adds all unique integers in a list.
    public static int Sum(List<int> myList)
    {
        List<int> newList = new List<int>();
        int sum = 0;

        foreach (int value in myList)
        {
            if (!newList.Contains(value))
                newList.Add(value);
        }

        foreach (int value in newList)
            sum += value;

        return (sum);
    }
}
