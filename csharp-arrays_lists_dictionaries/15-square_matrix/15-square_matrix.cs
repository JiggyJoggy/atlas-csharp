using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);
        int[,] newMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int x = 0; x < cols; x++)
            {
                newMatrix[i, x] = (int)Math.Pow(myMatrix[i, x], 2);
            }
        }
        return newMatrix;
    }
}