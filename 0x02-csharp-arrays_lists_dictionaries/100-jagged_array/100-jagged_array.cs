using System;
class Program
{
    // creates and prints a jagged array containing 3 arrays.
    static void Main(string[] args)
    {
        int[][] array = new int[][]
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1}
        };

        for (int x = 0; x < array.Length; x++)
        {
            for (int y = 0; y < array[x].Length; y++)
            {
                Console.Write(array[x][y]);
                if (y != array[x].Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
