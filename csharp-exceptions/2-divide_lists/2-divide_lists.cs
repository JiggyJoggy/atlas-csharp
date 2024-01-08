using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int sum = 0;
        List<int> newList = new List<int>();
        try
        {
            for (int i = 0; i < listLength; i++)
            {
                for (int j = 0; j < listLength; i++)
                {
                    if (list1[i] == 0 || list2[i] == 0)
                    {
                        sum = 0;
                        newList.Add(sum);
                    }
                    else
                    {
                        sum = list1[i] / list2[i];
                        newList.Add(sum);
                    }
                }
            }
        }
        catch
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Out of Range");
        }
        return newList;
    }
}