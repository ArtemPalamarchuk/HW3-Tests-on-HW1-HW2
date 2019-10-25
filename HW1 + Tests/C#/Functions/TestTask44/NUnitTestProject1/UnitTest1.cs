using NUnit.Framework;
using ConsoleApp4;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(SomeClass.Lengt(1, 0, 0, 0), 1);
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(SomeClass.Lengt(2, 1, 1, 2), Math.Sqrt(2));
        }

    }
}