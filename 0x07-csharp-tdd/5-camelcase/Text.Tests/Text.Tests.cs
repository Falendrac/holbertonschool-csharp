using System;
using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void TestNull()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }

        [TestCase("VousMeFaitesChierANousFaireDesTachesDeMerde")]
        public void TestNumberOfWords(string s)
        {
            Assert.AreEqual(11, Str.CamelCase(s));
        }
    }
}
