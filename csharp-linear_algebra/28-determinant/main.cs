using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 2, 5, 0, -2 }, { 0, 4, -1, 8 }, { 4, -3, 9, 1 }, { -1, 0, 2, 7 } };

        Console.WriteLine(MatrixMath.Determinant(matrix));
    }
}