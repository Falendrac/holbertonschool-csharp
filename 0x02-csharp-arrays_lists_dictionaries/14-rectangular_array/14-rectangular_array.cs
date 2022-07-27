using System;
using System.Collections.Generic;

class Program
{
    // Create and print a two dimensional array.
    static void Main(string[] args)
    {
        int[,] grid = new int[5, 5];

        grid[2, 2] = 1;

        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                Console.Write(grid [x, y]);
                if (y != 4)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
