using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index <= 98; index++)
            {
                Console.Write($"{index} = 0x{index:x}\n");
            }
        }
    }
}
