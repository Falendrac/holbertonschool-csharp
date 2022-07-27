using System;
using System.Collections.Generic;

class Dictionary
{
    // returns the number of keys in a dictionary
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;

        if (myDict == null)
        {
            return count;
        }
        
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            count++;
        }

        return count;
    }
}
