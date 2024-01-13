using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }
            else
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] newMatrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        try
                        {
                            newMatrix[i, j] = matrix[i, j] / num;
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Num cannot be 0");
                            return null;
                        }
                    }
                }
                return newMatrix;
            }
        }
    }
}
