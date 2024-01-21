using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] mathMatrix = 
        {
            {Math.Cos(angle), Math.Sin(angle)},
            {-Math.Sin(angle), Math.Cos(angle)}
        };

        if (rows == 2 && cols == 2)
        {
            double[,] allSum = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double sum = 0.0;

                    for (int k = 0; k < cols; k++)
                    {
                        sum += matrix[i, k] * mathMatrix[k, j];
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