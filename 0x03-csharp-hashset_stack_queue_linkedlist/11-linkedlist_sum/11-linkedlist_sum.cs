using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int value = 0;

        foreach (int element in myLList)
            value += element;

        return value;
    }
}
