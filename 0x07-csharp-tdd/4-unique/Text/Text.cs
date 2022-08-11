using System;
using System.Linq;

namespace Text
{
    /// <summary>Define the Str class and some functions</summary>
    public class Str
    {
        /// <summary>Search index of the first non-repeating character of a string.</summary>
        /// <param name="s">The string we check</param>
        /// <returns>index of first non-repeating character or -1 if there is no non-repeating character</returns>
        public static int UniqueChar(string s)
        {
            int occur;

            if (s == null || s.Length == 0)
                return (-1);

            for (int loop1 = 0; loop1 < s.Length; loop1++)
            {
                occur = 0;
                for (int loop2 = loop1 + 1; loop2 < s.Length; loop2++)
                {
                    if (s[loop1] == s[loop2])
                    {
                        occur++;
                        loop1 = loop2;
                    }
                }
                if (occur == 0)
                    return loop1;
            }
            return -1;
        }
    }
}
