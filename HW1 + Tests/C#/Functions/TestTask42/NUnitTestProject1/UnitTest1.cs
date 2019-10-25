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
            Assert.AreEqual(SomeClass.Propys(7), "�� ");
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(SomeClass.Propys(14), "������������ ");
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual(SomeClass.Propys(110), "��� ������ ");
        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual(SomeClass.Propys(341), "������ ����� ���� ");
        }

        [Test]
        public void TestMethod5()
        {
            Assert.AreEqual(SomeClass.Propys(32), "�������� ��� ");
        }

        [Test]
        public void TestMethod6()
        {
            Assert.AreEqual(SomeClass.Propys(9999), "������ ����� �� 0 �� 999 ");
        }

        [Test]
        public void TestMethod7()
        {
            Assert.AreEqual(SomeClass.Propys(0), "���� ");
        }
    }
}

