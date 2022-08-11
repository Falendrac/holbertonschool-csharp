using System;
using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void UniqueCharValidCase()
        {
            Assert.AreEqual(0, Str.UniqueChar("bite"));
            Assert.AreEqual(4, Str.UniqueChar("bbiite"));
        }

        [Test]
        public void UniqueCharUnvalidCase()
        {
            Assert.AreEqual(-1, Str.UniqueChar("bbbbbbbbb"));
        }
    }
}
