using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> newList = new List<int>();
        try
        {
            for (int index = 0; index < listLength; index++)
            {
                newList.Add(list1[index]/list2[index]);
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            newList.Add(0);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range");
        }
        return newList;
    }
}