using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index <= 99; index++)
            {
                if (index == 99)
                {
                    Console.WriteLine("99");
                    break;
                }
                Console.Write($"{index:D2}, ");
            }
        }
    }
}
