﻿using System;
using System.Collections.Generic;

class List
{
    // returns a sorted list of common elements in two lists
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        for (int loop = 0; loop < list1.Count; loop++)
        {
            if (list2.Contains(list1[loop]))
            {
                newList.Add(list1[loop]);
            }
        }

        newList.Sort();

        return newList;
    }
}
