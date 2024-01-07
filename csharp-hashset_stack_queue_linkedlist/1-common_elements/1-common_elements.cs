using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonList = new List<int>();
        foreach (int number in list1)
        {
            foreach (int number_2 in list2)
            {
                if (number == number_2)
                {
                    commonList.Add(number);
                }
            }
        }
        return commonList;
    }
}