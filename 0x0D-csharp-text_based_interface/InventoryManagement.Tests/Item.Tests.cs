using NUnit.Framework;
using System;

namespace InventoryManagement.Tests
{
    /// <summary>All tests for Item class</summary>
    public class ItemTests
    {
        /// <summary>
        /// Test if Item inherit from BaseClass
        /// </summary>
        [Test]
        public void TestItemFromBase()
        {
            Assert.True(typeof(Item).IsSubclassOf(typeof(BaseClass)));
        }

        /// <summary>
        /// Test if the name of Item is not empty when the instance was created
        /// </summary>
        [Test]
        public void TestNameNotEmpty()
        {
            Item testItem = new Item();

            Assert.IsNotNull(testItem.name);
        }

        /// <summary>
    }
}
