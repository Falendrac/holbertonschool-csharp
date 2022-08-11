using System;
using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void PalindromeValidNormalCase()
        {
            Assert.IsTrue(Str.IsPalindrome("kayak"));
        }

        [Test]
        public void PalindromeUnvalidNormalCase()
        {
            Assert.IsFalse(Str.IsPalindrome("hello"));
        }

        [Test]
        public void PalindromeEmpty()
        {
            Assert.IsTrue(Str.IsPalindrome(null));
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void PalindromeStrWithPunctuation()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void PalindromeStrWithUppercase()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }
    }
}
