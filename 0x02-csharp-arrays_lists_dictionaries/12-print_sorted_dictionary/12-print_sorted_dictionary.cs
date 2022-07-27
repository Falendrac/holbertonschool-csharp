using System;
using System.Collections.Generic;

class Dictionary
{
    // prints a dictionary by ordered keys.
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        foreach (KeyValuePair<string, string> pair in myDict.OrderBy(x => x.Key))
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
    }
}
