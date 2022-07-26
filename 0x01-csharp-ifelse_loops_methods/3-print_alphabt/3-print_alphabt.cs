using System;

class Program
{
    static void Main(string[] args)
    {
        for (char loop = 'a'; loop <= 'z'; loop++)
        {
            if (loop != 'q' && loop != 'e')
            {
                Console.Write(loop);
            }
        }
    }
}
