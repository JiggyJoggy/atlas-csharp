using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine("");
            }
            else
            {
                for (int index = 0; index <= length; index++)
                {
                    for (int space = 1; space < index; space++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("\\");
                }
            }
        }
    }
}
