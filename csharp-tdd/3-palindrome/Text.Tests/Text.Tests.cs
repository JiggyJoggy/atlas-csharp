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
        [TestCase("level", true)]
        [TestCase("Racecar", true)]
        [TestCase("taco cat", true)]
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("", true)]
        public void Test_Text_Output(string s, bool expectedBool)
        {
            bool word = Text.Str.IsPalindrome(s);

            Assert.AreEqual(expectedBool, word);
        }
    }
}