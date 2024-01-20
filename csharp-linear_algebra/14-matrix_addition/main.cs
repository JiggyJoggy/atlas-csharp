using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 2, -9, 7 }, { 8, -6, 2 }, { -2, 5, -3 } };
        double[,] matrix2 = { { 3, -1, 0 }, { 1, 4, 4 } };
        double[,] result;

        result = MatrixMath.Add(matrix1, matrix2);

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