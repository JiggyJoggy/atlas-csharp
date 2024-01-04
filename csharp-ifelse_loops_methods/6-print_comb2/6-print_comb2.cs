using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int x = i + 1; x <= 9; x++)
                {
                    if (i != x)
                    {
                        Console.Write($"{i}{x}");
                        if (i == 8 && x == 9)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }
        }
    }
}
