using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        foreach (var element in myLList)
        {
            if (element > n)
            {
                myLList.AddBefore(myLList.Find(element), n);
                break;
            }
        }

        if (!myLList.Contains(n))
            myLList.AddLast(n);

        return myLList.Find(n);
    }
}
