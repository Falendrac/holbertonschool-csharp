using System;

class Program
{
    static void Main(string[] args)
    {
        for (int loop = 0; loop < 100; loop++)
        {
            if (loop != 99)
            {
                Console.Write("{0:D2}, ", loop);
            }
            else
            {
                Console.Write("{0:D2}\n", loop);
            }
        }
    }
}
