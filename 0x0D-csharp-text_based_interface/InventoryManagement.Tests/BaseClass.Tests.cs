using NUnit.Framework;
using System;
using InventoryLibrary;

namespace InventoryManagement.Tests
{

    public class BaseClassTests
    {
        [SetUp]
        public void Setup()
        {
            BaseClass testBaseClass = new BaseClass();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
