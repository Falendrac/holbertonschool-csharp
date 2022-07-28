using System;
using System.Collections.Generic;

class List
{
    // adds all unique integers in a list.
    public static int Sum(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            return 0;
        }

        return myList.Distinct().Sum(x => Convert.ToInt32(x));
    }
}
