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
            Assert.AreEqual(SomeClass.Chyslo("��"), 7);
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(SomeClass.Chyslo("������������"), 14);
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual(SomeClass.Chyslo("��� ������"), 110);
        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual(SomeClass.Chyslo("������ ����� ����"), 341);
        }

        [Test]
        public void TestMethod5()
        {
            Assert.AreEqual(SomeClass.Chyslo("�������� ���"), 32);
        }

        [Test]
        public void TestMethod6()
        {
            Assert.AreEqual(SomeClass.Chyslo("��� ����"), -1);
        }

        [Test]
        public void TestMethod7()
        {
            Assert.AreEqual(SomeClass.Chyslo("����"), 0);
        }

        [Test]
        public void TestMethod8()
        {
            Assert.AreEqual(SomeClass.Chyslo("������ ������"), -1);
        }

    }
}