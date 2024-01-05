using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
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
