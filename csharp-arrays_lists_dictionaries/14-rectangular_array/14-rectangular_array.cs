using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] rectangle = new int[5, 5];
        rectangle[2, 2] = 1;

        for (int col = 0; col < 5; col++)
        {
            for (int row = 0; row < 5; row++)
            {
                Console.Write($"{rectangle[col, row]}");
                if (row < 4)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}