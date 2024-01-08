using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newList = new LinkedList<int>();

        if (size < 0)
        {
            return newList;
        }
        for (int index = 0; index < size; index++)
        {
            newList.AddLast(index);
        }
        foreach (int element in newList)
        {
            Console.WriteLine(element);
        }
        return newList;
    }
}