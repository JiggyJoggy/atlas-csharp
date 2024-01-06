using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);
        int[,] newMatrix = new int[cols, rows];

        for (int index = 0; index < cols; index++)
        {
            for (int x = 0; x < rows; x++)
            {
                newMatrix[x, index] = myMatrix[x, index] * myMatrix[x, index];
            }
        }
        return newMatrix;
    }
}