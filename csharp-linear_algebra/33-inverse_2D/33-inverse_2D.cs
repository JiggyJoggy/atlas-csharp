using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] badMatrix = {{-1}};

        if ((rows != cols) || (rows <= 0 || cols <= 0) || (rows > 2 || cols > 2))
        {
            return badMatrix;
        }

        double[,] newMatrix = new double[rows, cols];

        double det = Math.Round((matrix[0,0] * matrix[1,1]) - (matrix[0,1] * matrix[1,0]), 2);

        newMatrix[0,0] = Math.Round((matrix[1,1] / det), 2);
        newMatrix[0,1] = Math.Round((-matrix[0,1] / det), 2);
        newMatrix[1,0] = Math.Round((-matrix[1,0] / det), 2);
        newMatrix[1,1] = Math.Round((matrix[0,0] / det), 2);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (Double.IsInfinity(newMatrix[i,j]))
                {
                    return badMatrix;
                }
            }
        }

        return newMatrix;
    }
}