using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        int[,] testMatrix;
        [SetUp]
        public void Setup()
        {
            testMatrix = new int[2, 2];
            testMatrix[0, 0] = 2;
            testMatrix[0, 1] = 4;
            testMatrix[1, 0] = 6;
            testMatrix[1, 1] = 8;
        }

        [TestCase(1)]
        [TestCase(2)]
        public void Test_Matrix_Output(int value)
        {
            int[,] createdMatrix = MyMath.Matrix.Divide(testMatrix, value);
            
            Assert.AreEqual(2 / value, createdMatrix[0, 0]);
        }

        [Test]
        public void Test_Null_Return()
        {
            Assert.IsNull(MyMath.Matrix.Divide(null, 2));
        }

        [Test]
        public void Test_Divide_By_Zero()
        {
            Assert.IsNull(MyMath.Matrix.Divide(testMatrix, 0));
        }
    }
}