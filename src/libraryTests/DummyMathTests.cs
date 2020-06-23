using NUnit.Framework;
using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Tests
{
    [TestFixture()]
    public class DummyMathTests
    {
        [Test]
        public void AddTest()
        {
            Assert.AreEqual(4, DummyMath.Add(1, 3));
            Assert.AreEqual(-3, DummyMath.Add(-6, 3));
            Assert.AreEqual(0, DummyMath.Add(-51, 51));
        }

        [Test]
        public void SubstractTest()
        {
            Assert.AreEqual(4, DummyMath.Substract(8, 4));
            Assert.AreEqual(-3, DummyMath.Substract(1, 4));
            Assert.AreEqual(0, DummyMath.Substract(10, 10));
        }

        [Test]
        public void MultiplyTest()
        {
            Assert.AreEqual(5, DummyMath.Multiply(-5, -1));
            Assert.AreEqual(0, DummyMath.Multiply(25.2, 0));
            Assert.AreEqual(1640.52, DummyMath.Multiply(25.2, 65.1), 1e-3);
        }

        [Test]
        public void DivideTest()
        {
            Assert.AreEqual(2.5, DummyMath.Divide(15, 6));
            Assert.AreEqual(3, DummyMath.Divide(9, 3));
            Assert.AreEqual(0, DummyMath.Divide(0, 6));
        }
        [Test()]
        public void DivideWithZeroTest()
        {
            Assert.Throws(typeof(ArgumentException), () => DummyMath.Divide(231, 0));
        }

        [Test]
        public void PowTest()
        {
            Assert.AreEqual(8, DummyMath.Pow(2, 3));
            Assert.AreEqual(3.7, DummyMath.Pow(50.653, 1.0 / 3.0), 1e-2);
        }
    }
}