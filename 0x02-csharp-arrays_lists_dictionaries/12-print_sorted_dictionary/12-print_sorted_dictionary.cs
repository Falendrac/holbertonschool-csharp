using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    // prints a dictionary by ordered keys.
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        foreach (KeyValuePair<string, string> pair in myDict.OrderBy(key => key.Key))
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
