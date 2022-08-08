using System;
using System.Collections.Generic;

class List
{
    // function that divides element by element 2 lists
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        for (int loop = 0; loop < listLength; loop++)
        {
            try
            {
                result.Add(list1[loop] / list2[loop]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                break;
            }
        }

        return result;
    }
}
