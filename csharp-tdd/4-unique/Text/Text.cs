using System;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j && s[i] == s[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
