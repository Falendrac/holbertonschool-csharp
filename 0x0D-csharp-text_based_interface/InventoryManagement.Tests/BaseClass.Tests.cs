using NUnit.Framework;
using System;

namespace InventoryManagement.Tests
{

    public class BaseClassTests
    {
        [Test]
        public void TestTypeProperties()
        {
            BaseClass testBaseClass = new BaseClass();

            Assert.IsInstanceOf(testBaseClass.id, typeof(string));
            Assert.IsInstanceOf(testBaseClass.date_created, typeof(DateTime));
            Assert.IsInstanceOf(testBaseClass.date_updated, typeof(DateTime));
        }
    }
}
