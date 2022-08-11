using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void TestsValidCase()
        {
            List<int> nums = new List<int>(){1, 10, 2, 40, 21, 23};

            Assert.AreEqual(40, Operations.Max(nums));

            nums = new List<int>(){1, 10, 2, 4, 21, 23};

            Assert.AreEqual(23, Operations.Max(nums));

            nums = new List<int>(){100, 10, 2, 4, 21, 23};

            Assert.AreEqual(100, Operations.Max(nums));
        }

        [Test]
        public void TestsEmpty()
        {
             List<int> nums = new List<int>();

             Assert.AreEqual(0, Operations.Max(nums));

             Assert.AreEqual(0, Operations.Max(null));
        }
    }
}
