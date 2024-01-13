using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] {1, 2, 3, 4, 5}, 5)]
        [TestCase(new int[] {7, 4, 3, 2, 1}, 7)]
        [TestCase(new int[] {1, 2, 9, 4, 5}, 9)]
        [TestCase(new int[] {-5, 7, 6, 10, 2}, 10)]
        [TestCase(new int[] {}, 0)]
        public void Test_List_Output(int[] num, int expectedSum)
        {
            List<int> newList = new List<int>(num);

            int sum = MyMath.Operations.Max(newList);

            Assert.AreEqual(expectedSum, sum);
        }
    }
}