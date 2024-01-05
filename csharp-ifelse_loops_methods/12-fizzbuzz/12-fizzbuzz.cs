using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 100; index++)
            {
                if (index % 3 == 0 && index % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (index % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (index % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write($"{index}");
                }
                if (index == 100)
                {
                    Console.WriteLine("");
                    break;
                }
                Console.Write(" ");
            }
        }
    }
}
