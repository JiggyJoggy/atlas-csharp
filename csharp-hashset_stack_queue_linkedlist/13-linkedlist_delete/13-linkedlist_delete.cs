using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int tempIndex = 0;

        foreach (int element in myLList)
        {
            if (tempIndex == index)
            {
                myLList.Remove(element);
                break;
            }
            tempIndex++;
        }
    }
}