using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 1, 2 }, { -4, 6 } };
        double[,] matrix2 = { { 3, 7, 11 }, { 4, 3, 4 }, { 6, -5, 5 } };
        double[,] result;

        result = MatrixMath.Multiply(matrix1, matrix2);

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j]);
                if (j != result.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}