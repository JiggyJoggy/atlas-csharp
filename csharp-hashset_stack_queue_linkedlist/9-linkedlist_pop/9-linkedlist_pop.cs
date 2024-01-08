using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int saveData = 0;
        if (myLList.Count > 0)
        {
            saveData = myLList.First.Value;
            myLList.Remove(myLList.First);
            return saveData;
        }
        else
        {
            return 0;
        }
    }
}