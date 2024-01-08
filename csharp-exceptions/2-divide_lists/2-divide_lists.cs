using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int sum = 0;
        bool checkedAlready = false;
        List<int> newList = new List<int>();
        try
        {
            for (int i = 0; i < listLength; i++)
            {
                try
                {
                    if (list2[i] == 0 || list1[i] == 0)
                    {
                        newList.Add(0);
                        throw new DivideByZeroException();
                    }
                    sum = list1[i] / list2[i];
                    newList.Add(sum);
                }
                catch
                {
                    if (!checkedAlready)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        checkedAlready = true;
                    }
                }
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Out of Range");
        }
        return newList;
    }
}