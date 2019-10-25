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
            Assert.AreEqual(SomeClass.Propys(7), "с≥м ");
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(SomeClass.Propys(14), "чотирнадц€ть ");
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual(SomeClass.Propys(110), "сто дес€ть ");
        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual(SomeClass.Propys(341), "триста сорок один ");
        }

        [Test]
        public void TestMethod5()
        {
            Assert.AreEqual(SomeClass.Propys(32), "тридц€ть два ");
        }

        [Test]
        public void TestMethod6()
        {
            Assert.AreEqual(SomeClass.Propys(9999), "введ≥ть число в≥д 0 до 999 ");
        }

        [Test]
        public void TestMethod7()
        {
            Assert.AreEqual(SomeClass.Propys(0), "нуль ");
        }
    }
}

