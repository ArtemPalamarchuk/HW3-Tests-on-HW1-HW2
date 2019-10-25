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
            Assert.AreEqual(SomeClass.Propys2(7), "��");
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(SomeClass.Propys2(14), "������������");
        }

        [Test]
        public void TestMethod3()
        {
            Assert.AreEqual(SomeClass.Propys2(110), "��� ������");
        }

        [Test]
        public void TestMethod4()
        {
            Assert.AreEqual(SomeClass.Propys2(341), "������ ����� ����");
        }

        [Test]
        public void TestMethod5()
        {
            Assert.AreEqual(SomeClass.Propys2(32), "�������� ���");
        }

        [Test]
        public void TestMethod6()
        {
            Assert.AreEqual(SomeClass.Propys2(9999), "���'��� ����� ���'����� ���'������ ���'���");
        }

        [Test]
        public void TestMethod7()
        {
            Assert.AreEqual(SomeClass.Propys2(0), "����");
        }

        [Test]
        public void TestMethod8()
        {
            Assert.AreEqual(SomeClass.Propys2(123654733001), "��� �������� ��� ������� ������� �'������� ������ ������� ����� �������� ��� ������ ����");
        }

        [Test]
        public void TestMethod9()
        {
            Assert.AreEqual(SomeClass.Propys2(123000000001), "��� �������� ��� ������� ����");
        }
        [Test]
        public void TestMethod10()
        {
            Assert.AreEqual(SomeClass.Propys2(1236547330019), "������ �������� �����");
        }
        [Test]
        public void TestMethod11()
        {
            Assert.AreEqual(SomeClass.Propys2(701225513), "����� ���� ������ ���� �������� �'��� ����� �'����� ����������");
        }
    }
}

