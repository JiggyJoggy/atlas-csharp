using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array = new int[size];

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            Console.WriteLine();
        }
        if (size > 0)
        {
            for (int index = 0; index < size; index++)
            {
                array[index] = index;
            }
        }
        return array;
    }
}
