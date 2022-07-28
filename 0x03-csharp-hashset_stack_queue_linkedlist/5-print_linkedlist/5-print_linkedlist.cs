using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> llist = new LinkedList<int>();

        for (int loop = 0; loop < size; loop++)
        {
            llist.AddLast(loop);
        }

        foreach (int element in llist)
            Console.WriteLine(element);

        return llist;
    }
}
