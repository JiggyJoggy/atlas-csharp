using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> check = new List<bool>();

        foreach (int number in myList)
        {
            if (number % 2 == 0)
            {
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
        }
        return check;
    }
}