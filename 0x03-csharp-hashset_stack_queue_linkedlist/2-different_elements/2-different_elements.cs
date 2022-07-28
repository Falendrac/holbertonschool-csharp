using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        int maxLength = 0;

        if (list1.Count > list2.Count)
            maxLength = list1.Count;
        else
            maxLength = list2.Count;

        List<int> newList = new List<int>();

        for (int loop = 0; loop < maxLength; loop++)
        {
            if (loop < list1.Count)
            {
                if (!list2.Contains(list1[loop]))
                    newList.Add(list1[loop]);
            }

            if (loop < list2.Count)
            {
                if (!list1.Contains(list2[loop]))
                    newList.Add(list2[loop]);
            }
        }
        
        newList.Sort();

        return newList;
    }
}
