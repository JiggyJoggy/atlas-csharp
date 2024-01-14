using NUnit.Framework;
using System.Text;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase()]
        public void Test_Text_Output(string s, string expectedString)
        {
            string word = Text.Str.IsPalindrome(s);

            Assert.AreEqual(expectedString, word);
        }
    }
}