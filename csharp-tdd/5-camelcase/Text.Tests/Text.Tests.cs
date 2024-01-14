using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("hello", 1)]
        [TestCase("helloWorld", 2)]
        [TestCase("helloAgainWorld", 3)]
        [TestCase("helloWorldIAmHere", 5)]
        [TestCase("", 0)]
        public void Test_CamelCase_Output(string s, int expectedCount)
        {
            int sum = Text.Str.CamelCase(s);

            Assert.AreEqual(expectedCount, sum);
        }
    }
}