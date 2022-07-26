using System;

class Program
{
    static void Main(string[] args)
    {
        for (int loop1 = 0; loop1 < 10; loop1++)
        {
            for (int loop2 = loop1 + 1; loop2 < 10; loop2++)
            {
                if (loop1 != 8)
                {
                    Console.Write("{0}{1}, ", loop1, loop2);
                }
                else
                {
                    Console.WriteLine("{0}{1}", loop1, loop2);
                }
            }
        }
    }
}
