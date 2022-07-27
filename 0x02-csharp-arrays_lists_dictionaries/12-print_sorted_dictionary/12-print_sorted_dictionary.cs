using System;
using System.Collections.Generic;

class Dictionary
{
    // prints a dictionary by ordered keys.
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sorted = myDict.OrderBy(x => x.Key);

        foreach (KeyValuePair<string, string> pair in sorted)
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
    }
}
