using System;
using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void TestNull()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(null));
        }

        [Test]
        public void UniqueCharValidCase()
        {
            Assert.AreEqual(0, Str.UniqueChar("bite"));
            Assert.AreEqual(4, Str.UniqueChar("bbiite"));
        }

        [TestCase("ssttrr")]
        [TestCase("tteesstt")]
        [TestCase("testtest")]
        [TestCase("strstr")]
        public void TestNonUniqueChar(string nonUnique)
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(nonUnique));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(""));
        }
    }
}
