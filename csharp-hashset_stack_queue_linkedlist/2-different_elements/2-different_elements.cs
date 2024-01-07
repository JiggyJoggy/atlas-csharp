using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        SortedSet<int> sortDiff = new SortedSet<int>();
        foreach (int number in list1)
        {
            if (!list2.Contains(number))
            {
                sortDiff.Add(number);
            }
        }
        foreach (int number in list2)
        {
            if (!list1.Contains(number))
            {
                sortDiff.Add(number);
            }
        }
        List<int> diffList = new List<int>(sortDiff);
        return diffList;
    }
}