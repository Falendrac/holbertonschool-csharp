using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    // returns the key with the biggest integer value in a given dictionary.
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null)
        {
            return "None";
        }

        var sortedDict = from entry in myList orderby entry.Value descending select entry;

        return sortedDict.First().Key;
    }
}
