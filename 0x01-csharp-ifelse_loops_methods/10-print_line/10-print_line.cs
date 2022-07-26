using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length > 0)
        {
            for (int loop = 0; loop < length; loop++)
            {
                Console.Write("_");
            }
        }
        Console.WriteLine();
    }
}
