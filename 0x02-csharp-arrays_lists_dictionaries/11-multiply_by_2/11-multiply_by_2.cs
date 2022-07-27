using System;
using System.Collections.Generic;

class Dictionary
{
    // returns a new dictionary with all values multiplied by 2.
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        if (myDict == null)
        {
            return null;
        }

        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> pair in myDict)
        {
            newDict.Add(pair.Key, pair.Value * 2);
        }

        return newDict;
    }
}
