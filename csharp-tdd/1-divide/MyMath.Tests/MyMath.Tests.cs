using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private static object[] TestCases =
        {
            new object[] { new int[,] { { 2, 4, 6 }, { 8, 10, 12 } }, 2, new int[,] { { 1, 2, 3 }, { 4, 5, 6 } } }
        };

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test_Matrix_Output(int[,] matrix, int num, int[,] expectedMatrix)
        {
            int[,] createdMatrix = MyMath.Matrix.Divide(matrix, num);

            int rows = expectedMatrix.GetLength(0);
            int cols = expectedMatrix.GetLength(1);

            Assert.AreEqual(rows, createdMatrix.GetLength(0));
            Assert.AreEqual(cols, createdMatrix.GetLength(1));

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Assert.AreEqual(expectedMatrix[i, j], createdMatrix[i, j]);
                }
            }
        }
    }
}