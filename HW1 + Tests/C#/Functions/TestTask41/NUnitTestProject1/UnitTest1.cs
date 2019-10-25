using NUnit.Framework;
using ConsoleApp4;

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
            Assert.AreEqual(SomeClass.Days(7), "Sunday");
        }
        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(SomeClass.Days(1), "Monday");
        }
        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual(SomeClass.Days(9), "wrong number");
        }
    }
}

