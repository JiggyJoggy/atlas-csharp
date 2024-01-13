using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3, 4, 7)]
        [TestCase(-3, -4, -7)]
        [TestCase(4, -2, 2)]
        [TestCase(0, -7, -7)]
        [TestCase(0, 0, 0)]
        public void Test_Add(int a, int b, int expectedSum)
        {
            int sum = MyMath.Operations.Add(a, b);

            Assert.AreEqual(expectedSum, sum);
        }
    }
}