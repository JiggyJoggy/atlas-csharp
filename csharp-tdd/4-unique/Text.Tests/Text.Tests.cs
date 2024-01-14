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
        [TestCase("helloworld", 0)]
        [TestCase("helloholberton", 8)]
        [TestCase("aabbccddeef", 10)]
        [TestCase("hellohello", -1)]
        [TestCase("", -1)]
        public void Test_Unique_Char(string s, int expectedIndex)
        {
            int index = Text.Str.UniqueChar(s);

            Assert.AreEqual(expectedIndex, index);
        }
    }
}