using System;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            if (s == "")
            {
                return true;
            }
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
