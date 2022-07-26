using System;

class Program
{
    static void Main(string[] args)
    {
        for (int loop = 1; loop <= 100; loop++)
        {
            if (loop % 3 == 0 && loop % 5 == 0)
            {
                Console.Write("FizzBuzz");
            }
            else if (loop % 3 == 0)
            {
                Console.Write("Fizz");
            }
            else if (loop % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.Write(loop);
            }

            if (loop < 100)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
