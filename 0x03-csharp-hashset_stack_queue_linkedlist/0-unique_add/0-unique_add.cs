using System;
using System.Collections.Generic;

class List
{
    // adds all unique integers in a list.
    public static int Sum(List<int> myList)
    {
        List<int> tmp = new List<int>();
        int sum = 0;

        foreach (var element in myList)
        {
            if (!tmp.Contains(element))
                tmp.Add(element);
        }

        sum = tmp.Sum(x => Convert.ToInt32(x));

        return sum;
    }
}
