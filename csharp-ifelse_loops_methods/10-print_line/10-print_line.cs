using System;

namespace _10_print_line
{
    class Line
    {
        public static void PrintLine(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine("");
            }
            else
            {
                for (int index = 0; index <= length; index++)
                {
                    Console.Write("_");
                }
                Console.WriteLine("");
            }
        }
    }
}
