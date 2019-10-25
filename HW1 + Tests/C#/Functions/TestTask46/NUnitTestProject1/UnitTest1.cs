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
            Assert.AreEqual(SomeClass.Chyslo("с≥м"), 7);
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(SomeClass.Chyslo("чотирнадц€ть"), 14);
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual(SomeClass.Chyslo("сто дес€ть"), 110);
        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual(SomeClass.Chyslo("триста сорок один"), 341);
        }

        [Test]
        public void TestMethod5()
        {
            Assert.AreEqual(SomeClass.Chyslo("тридц€ть два"), 32);
        }

        [Test]
        public void TestMethod6()
        {
            Assert.AreEqual(SomeClass.Chyslo("сто п≥цот"), -1);
        }

        [Test]
        public void TestMethod7()
        {
            Assert.AreEqual(SomeClass.Chyslo("нуль"), 0);
        }

        [Test]
        public void TestMethod8()
        {
            Assert.AreEqual(SomeClass.Chyslo("м≥льйон м≥льйон"), -1);
        }

    }
}