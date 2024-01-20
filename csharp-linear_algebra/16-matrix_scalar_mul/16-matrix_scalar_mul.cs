using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if ((rows <= 3 && cols <=3) && (rows > 1 && cols > 1))
        {
            double[,] sum = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum[i, j] = matrix[i, j] * scalar;
                }
            }
            return sum;
        }
        else
        {
            double[,] badMatrix = {{-1}};
            return badMatrix;
        }
    }
}