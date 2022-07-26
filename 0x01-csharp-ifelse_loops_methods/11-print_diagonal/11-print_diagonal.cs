using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int loop1 = 0; loop1 < length; loop1++)
            {
                for (int loop2 = 0; loop2 < loop1; loop2++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
        }
        Console.WriteLine();
    }
}
