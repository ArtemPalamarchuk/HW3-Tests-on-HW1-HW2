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
            Assert.AreEqual(SomeClass.Propys2(7), "с≥м");
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(SomeClass.Propys2(14), "чотирнадц€ть");
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual(SomeClass.Propys2(110), "сто дес€ть");
        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual(SomeClass.Propys2(341), "триста сорок один");
        }

        [Test]
        public void TestMethod5()
        {
            Assert.AreEqual(SomeClass.Propys2(32), "тридц€ть два");
        }

        [Test]
        public void TestMethod6()
        {
            Assert.AreEqual(SomeClass.Propys2(9999), "дев'€ть тис€ч дев'€тсот дев'€носто дев'€ть");
        }

        [Test]
        public void TestMethod7()
        {
            Assert.AreEqual(SomeClass.Propys2(0), "нуль");
        }

        [Test]
        public void TestMethod8()
        {
            Assert.AreEqual(SomeClass.Propys2(123654733001), "сто двадц€ть три м≥ль€рди ш≥стсот п'€тдес€т чотири м≥льйони с≥мсот тридц€ть три тис€ч≥ один");
        }

        [Test]
        public void TestMethod9()
        {
            Assert.AreEqual(SomeClass.Propys2(123000000001), "сто двадц€ть три м≥ль€рди один");
        }
        [Test]
        public void TestMethod10()
        {
            Assert.AreEqual(SomeClass.Propys2(1236547330019), "введ≥ть коректне число");
        }
        [Test]
        public void TestMethod11()
        {
            Assert.AreEqual(SomeClass.Propys2(701225513), "с≥мсот один м≥льйон дв≥ст≥ двадц€ть п'€ть тис€ч п'€тсот тринадц€ть");
        }
    }
}

