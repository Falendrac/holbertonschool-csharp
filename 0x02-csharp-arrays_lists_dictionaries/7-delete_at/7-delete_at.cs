using System;
using System.Collections.Generic;

class List
{
    // deletes the item at a specific position in a list.
    // @myList: List of int where to remove an item
    // @index: The index of element to delete
    // Return: myList
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index > myList.Count - 1)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        int item = myList[index];

        myList.Remove(item);

        return myList;
    }
}
