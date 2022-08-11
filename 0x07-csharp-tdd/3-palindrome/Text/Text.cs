using System;
using System.Linq;

namespace Text
{
    /// <summary>Define the Str class and some functions</summary>
    public class Str
    {
        /// <summary>Check if a string is a palindrome</summary>
        /// <param name="s">The string we check</param>
        /// <returns>True if the string is a palindrome, False if is not</returns>
        public static bool IsPalindrome(string s)
        {
            try
            {
                string newS = "";

                foreach (char c in s)
                {
                    if (!char.IsPunctuation(c) && !Char.IsWhiteSpace(c))
                        newS += c;
                }

                newS = newS.ToLower();

                return newS.SequenceEqual(newS.Reverse());
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is NullReferenceException)
                    return true;

                throw;
            }
        }
    }
}
