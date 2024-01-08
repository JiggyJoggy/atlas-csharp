using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int valueIndex = 0;
        int currIndex = 0;
        
        foreach (var element in myLList)
        {
            currIndex++;
            if (currIndex == n + 1)
            {
                valueIndex = currIndex;
                return element;
            }
        }
        return 0;
    }
}