using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void TestDivisionNormalCase()
        {
            int[,] expected = { {1, 2}, {6, 6} };
            int[,] origin = { {2, 4}, {12, 12} };

            Assert.AreEqual(expected, Matrix.Divide(origin, 2));
        }

        [Test]
        public void TestNumZero()
        {
            int[,] origin = { {2, 4}, {12, 12} };

            Assert.IsNull(Matrix.Divide(origin, 0));
        }

        [Test]
        public void TestMatrixNull()
        {
            Assert.IsNull(Matrix.Divide(null, 2));
        }
    }
}
