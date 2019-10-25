using NUnit.Framework;
using Tests;

namespace NUnitTestProject3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConditionalOperators()
        {
            for (int i = 0; i != 100; ++i)
                Assert.AreEqual(SomeClass.Logic(1, i), i + 1);
        }

        [Test]
        public void TestSomeOtherLogic()
        {
            for (int i = 0; i != 100; ++i)
                Assert.AreEqual(SomeClass.Logic(8, i), i * 8);
        }

        [Test]
        public void TestSomeOtherLogic1()
        {
            for (int i = -100; i != 100; ++i)
                Assert.AreEqual(SomeClass.Logic(16, i), i * 16);
        }

        [Test]
        public void TestSomeOtherLogic2()
        {
            Assert.AreEqual(SomeClass.Logic(0, 0), 0);
        }

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(SomeClass.Task12(2, -3), "IV");
        }
        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(SomeClass.Task12(0, 0), "початок координат");
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual(SomeClass.Task12(0, 1), "Oy");

        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual(SomeClass.Task12(1, 0), "Ox");
        }

        [Test]
        public void TestMethod5()
        {
            Assert.AreEqual(SomeClass.Task12(-1, -1), "III");
        }

        [Test]
        public void TestMethod6()
        {
            Assert.AreEqual(SomeClass.Task12(-9, 1), "II");
        }

        [Test]
        public void TestMethod7()
        {
            Assert.AreEqual(SomeClass.Task12(9, 1), "I");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(SomeClass.Task13(5, 1, -9), 6);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(SomeClass.Task13(-5, -1, -9), 0);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(SomeClass.Task13(5, 1, 2), 8);
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(SomeClass.Task13(-5, 1, 9), 10);
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(SomeClass.Task13(5, -1, 9), 14);
        }


        [Test]
        public void TestMethod11()
        {
            Assert.AreEqual(SomeClass.Task14(1, 2, 4), 11);
        }

        [Test]
        public void TestMethod22()
        {
            Assert.AreEqual(SomeClass.Task14(0, 0, 0), 3);
        }

        [Test]
        public void TestMethod33()
        {
            Assert.AreEqual(SomeClass.Task14(1, 1, 1), 6);
        }

        [Test]
        public void TestMethod115()
        {
            Assert.AreEqual(SomeClass.Task15(0), "F");
        }

        [Test]
        public void TestMethod215()
        {
            Assert.AreEqual(SomeClass.Task15(20), "E");
        }

        [Test]
        public void TestMethod315()
        {
            Assert.AreEqual(SomeClass.Task15(45), "D");
        }

        [Test]
        public void TestMethod415()
        {
            Assert.AreEqual(SomeClass.Task15(65), "C");
        }

        [Test]
        public void TestMethod515()
        {
            Assert.AreEqual(SomeClass.Task15(80), "B");
        }

        [Test]
        public void TestMethod615()
        {
            Assert.AreEqual(SomeClass.Task15(100), "A");
        }

        [Test]
        public void TestMethod715()
        {
            Assert.AreEqual(SomeClass.Task15(101), "");
        }

    }

}