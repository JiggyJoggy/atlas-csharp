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
        [TestCase("helloWorld", 2)]
        [TestCase("helloAgainWorld", 3)]
        public void Test_CamelCase_Output(string s, int expectedCount)
        {
            int sum = Text.Str.CamelCase(s);

            Assert.AreEqual(expectedCount, sum);
        }
    }
}