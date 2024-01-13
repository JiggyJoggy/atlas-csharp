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
        public void Test_Matrix_Output(int[,] matrix, int num, int[,] expectedMatrix)
        {
            int[,] createdMatrix = MyMath.Matrix.Divide(matrix, num);

            Assert.AreEqual(expectedMatrix, matrix);
        }
    }
}