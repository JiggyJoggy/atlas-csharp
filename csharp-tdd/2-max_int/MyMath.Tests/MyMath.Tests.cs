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
        [TestCase(new int[] {}, 0)]
        public void Test_List_Output(int[] num, int expectedSum)
        {
            List<int> newList = new List<int>(num);

            int sum = MyMath.Operations.Max(newList);

            Assert.AreEqual(expectedSum, sum);
        }
    }
}