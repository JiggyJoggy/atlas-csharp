using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (matrix == {{}})
        {
            double[,] emptyMatrix = {{}};
            return emptyMatrix;
        }

        double[,] newMatrix = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                newMatrix[j, i] = matrix[i, j];
            }
        }
        return newMatrix;
    }
}