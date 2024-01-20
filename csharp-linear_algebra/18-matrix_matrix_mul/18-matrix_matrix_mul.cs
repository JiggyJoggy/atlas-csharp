using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int rows1 = matrix2.GetLength(0);
        int cols1 = matrix2.GetLength(1);

        if ((rows > 0 && cols1 > 0) && (rows1 == cols))
        {
            double[,] allSum = new double[rows, cols1];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    double sum = 0.0;

                    for (int k = 0; k < cols; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    allSum[i, j] = sum;
                }
            }
            return allSum;
        }
        else
        {
            double[,] badMatrix = {{-1}};
            return badMatrix;
        }
    }
}