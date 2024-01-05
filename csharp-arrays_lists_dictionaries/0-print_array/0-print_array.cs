using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size == 0)
            {
                Console.Write("");
            }
            else if (size < 0)
            {
                Console.Write("Size cannot be negative");
                return null;
            }
            else
            {
                int[] array = new int[size];

                for (int index = 0; index < size; index++)
                {
                    array[index] = index;
                }
                return array;
            }
        }
    }
}
