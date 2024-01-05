using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length < 0)
        {
            Console.WriteLine();
            return;
        }
        for (int index = array.Length - 1; index > 0; index--)
        {
            if (index == 0)
            {
                Console.Write($"{array[index]}");
            }
            else
            {
                Console.Write($"{array[index]} ");
            }
        }
        Console.WriteLine();
    }
}
