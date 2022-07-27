using System;

class Array
{
    // Return the element at the index given in parameters
    // Check if the index is not out of range
    // @array: The array we want to catch an element
    // @index: The index of the element
    // Return: -1 if index is out of range, Otherwise return the element
    public static int elementAt(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }

        return array[index];
    }
}
