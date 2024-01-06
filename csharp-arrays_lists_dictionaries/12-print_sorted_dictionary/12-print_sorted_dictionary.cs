using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        ICollection<string> keys = myDict.Keys;
        List<string> sortKeys = new List<string>(keys);
        sortKeys.Sort();
        foreach (var key in sortKeys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}