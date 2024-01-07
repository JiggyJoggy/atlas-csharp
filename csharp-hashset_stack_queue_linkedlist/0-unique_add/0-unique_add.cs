using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> sumList = new List<int>();

        foreach (int number in myList)
        {
            if (!sumList.Contains(number))
            {
                sumList.Add(number);
            }
        }
        int sum = 0;

        foreach (int num in sumList)
        {
            sum += num;
        }
        return sum;
    }
}