using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int tempIndex = 0;
        try
        {
            for (int index = 0; index < n; index++)
            {
                Console.WriteLine($"{myList[index]}");
                tempIndex++;
            }
        }
        catch
        {

        }
        return tempIndex;
    }
}