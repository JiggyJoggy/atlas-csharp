using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int rows1 = matrix2.GetLength(0);
        int cols1 = matrix2.GetLength(1);

        if (cols != rows1)
        {
            double[,] allSum = new double[rows, cols1];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    double sum = 0.0;

                    for (int k = 0; k < cols; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return allSum[i, j] = sum;
        }
        else
        {
            double[,] badMatrix = {{-1}};
            return badMatrix;
        }
    }
}