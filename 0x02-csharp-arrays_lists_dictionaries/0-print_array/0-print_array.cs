using System;

class Array
{
    // Create and initialize an array of int with a size of size
    // And print all iteration of the size
    // @size: The size of the array
    // Return null if size is negative, otherwise, return an array
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] newArray = new int[size];

        for (int loop = 0; loop < size; loop++)
        {
            newArray[loop] = loop;
            Console.Write(loop);
            if (loop != size - 1)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    
        return newArray;
    }
}
