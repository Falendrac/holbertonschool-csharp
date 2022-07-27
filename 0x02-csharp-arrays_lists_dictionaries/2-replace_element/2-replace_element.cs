using System;

class Array
{
    // Return the updated array
    // Check if the index is not out of range
    // @array: The array we want to update
    // @index: The index of the element
    // @n: The new value of array[index]
    // Return: The array
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array;
        }

        array[index] = n;

        return array;
    }
}
