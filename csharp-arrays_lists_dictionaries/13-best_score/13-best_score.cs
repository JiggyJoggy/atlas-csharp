using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count <= 0)
        {
            return "None";
        }
        int currScore = -1;
        string highscore = "";

        foreach (var score in myList)
        {
            if (score.Value > currScore)
            {
                currScore = score.Value;
                highscore = score.Key;
            }
        }
        return highscore;
    }
}