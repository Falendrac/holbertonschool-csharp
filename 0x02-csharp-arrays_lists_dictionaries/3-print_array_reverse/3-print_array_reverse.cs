using System;

class Array
{
    // Print all integers in an array, in reverse order
    // @array: The array to print
    public static void Reverse(int[] array)
    {
        if (array != null)
        {
            for (int loop = array.Length - 1; loop >= 0; loop--)
            {
                Console.Write(array[loop]);
                if (loop > 0)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}
