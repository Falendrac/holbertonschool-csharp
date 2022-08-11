using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationTests
    {
        [Test]
        public void TestAdditionPositivesNumbers()
        {
            Assert.AreEqual(30, Operations.Add(15, 15));
            Assert.AreEqual(26, Operations.Add(6, 20));
        }

        [Test]
        public void TestAdditionNegativesNumbers()
        {
            Assert.AreEqual(30, Operations.Add(60, -30));
            Assert.AreEqual(0, Operations.Add(-48, 48));
        }
    }
}
