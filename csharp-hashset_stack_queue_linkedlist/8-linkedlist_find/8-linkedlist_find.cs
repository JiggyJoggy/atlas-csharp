using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int valueIndex = -1;
        int currIndex = -1;
        foreach (var element in myLList)
        {
            currIndex++;
            if (element == value)
            {
                valueIndex = currIndex;
                return valueIndex;
            }
        }
        return valueIndex;
    }
}