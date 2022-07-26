using System;

class Program
{
    static void Main(string[] args)
    {
        for (int loop = 0; loop < 99; loop++)
        {
            Console.WriteLine("{0} = 0x{0:x}", loop);
        }
    }
}
