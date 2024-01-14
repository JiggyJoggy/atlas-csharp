using System;
using System.Text;

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
            StringBuilder filteredString = new StringBuilder();
            
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    filteredString.Append(char.ToLower(c));
                }
            }

            for (int i = 0; i < filteredString.Length / 2; i++)
            {
                if (filteredString[i] != filteredString[filteredString.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
