using NUnit.Framework;
using System;

namespace InventoryManagement.Tests
{

    /// <summary>All tests for BaseClass</summary>
    public class BaseClassTests
    {
        /// <summary>
        /// Test the type of all properties
        /// </summary>
        [Test]
        public void TestTypeProperties()
        {
            BaseClass testBaseClass = new BaseClass();

            Assert.True(testBaseClass.id.GetType() == typeof(string));
            Assert.True(testBaseClass.date_created.GetType() == typeof(DateTime));
            Assert.True(testBaseClass.date_updated.GetType() == typeof(DateTime));
        }

        /// <summary>
        /// Test if properties is not empty
        /// </summary>
        [Test]
        public void TestIsNotEmpty()
        {
            BaseClass testBaseClass = new BaseClass();

            Assert.IsNotNull(testBaseClass.id);
            Assert.IsNotNull(testBaseClass.date_created);
            Assert.IsNotNull(testBaseClass.date_updated);
        }

        /// <summary>
        /// Test if the id of two instances is unique
        /// </summary>
        [Test]
        public void TestUniqueId()
        {
            BaseClass testBaseClass0 = new BaseClass();
            BaseClass testBaseClass1 = new BaseClass();

            Assert.AreNotEqual(testBaseClass0.id, testBaseClass1.id);
        }

        /// <summary>
        /// Test if the dates is not the default value of Datetime
        /// </summary>
        [Test]
        public void TestDateDefault()
        {
            BaseClass testBaseClass = new BaseClass();
            DateTime dt = new DateTime();

            Assert.AreNotEqual(testBaseClass.date_created, dt);
            Assert.AreNotEqual(testBaseClass.date_updated, dt);
        }

        /// <summary>
        /// Test if date_created and date_updated was equal when the instance is created
        /// </summary>
        [Test]
        public void TestDatesAtCreation()
        {
            BaseClass testBaseClass = new BaseClass();

            Assert.AreEqual(testBaseClass.date_created, testBaseClass.date_updated);
        }

        /// <summary>
        /// Test if date_created and date_updated was not equal when the instance is updated
        /// </summary>
        [Test]
        public void TestDatesAtUpdate()
        {
            BaseClass testBaseClass = new BaseClass();
            testBaseClass.Update();

            Assert.AreNotEqual(testBaseClass.date_created, testBaseClass.date_updated);
        }
    }
}
