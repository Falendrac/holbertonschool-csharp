using System;
using System.Linq;

namespace Text
{
    /// <summary>Define the Str class and some functions</summary>
    public class Str
    {
        /// <summary>Determines how many words are in a string. Each word begins with a capital letter except the first word.</summary>
        /// <param name="s">The string we check</param>
        /// <returns>number of words in s</returns>
        public static int CamelCase(string s)
        {
            int count = 1;

            if (s == null || s.Length == 0)
                return (0);

            for (int browse = 1; browse < s.Length; browse++)
            {
                if (Char.IsUpper(s[browse]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
