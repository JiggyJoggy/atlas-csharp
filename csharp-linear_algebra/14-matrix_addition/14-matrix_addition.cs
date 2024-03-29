﻿using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        if (rows == matrix2.GetLength(0) && cols == matrix2.GetLength(1) && (rows > 1 && cols > 1))
        {
            double[,] sum = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
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