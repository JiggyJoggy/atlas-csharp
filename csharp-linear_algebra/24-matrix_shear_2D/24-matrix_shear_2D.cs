using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] shearMatrix;

        if (direction == 'x')
        {
            shearMatrix = new double[,] {{1, factor}, {0, 1}};
        }
        else if (direction == 'y')
        {
            shearMatrix = new double[,] {{1, 0}, {factor, 1}};
        }
        else
        {
            shearMatrix = {{-1}};
            return shearMatrix;
        }

        double[,] newMatrix = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double sum = 0.0;

                for (int k = 0; k < cols; k++)
                {
                    sum += matrix[i, k] * shearMatrix[k, j];
                }
                newMatrix[i, j] = sum;
            }
        }
        return newMatrix;
    }
}