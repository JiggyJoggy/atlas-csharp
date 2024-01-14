using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            int counter = 1;
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
