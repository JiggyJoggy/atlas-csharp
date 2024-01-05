using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> list = new List<int>();

        for (int index = 0; index < size; index++)
        {
            list.Add(index);
        }
        for (int x = 0; x < size; x++)
        {
            Console.Write(list[x]);
            if (x == size - 1)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
        if (size == 0)
        {
            Console.WriteLine();
        }
        return list;
    }
}
