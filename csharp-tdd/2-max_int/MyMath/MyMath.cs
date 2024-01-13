using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }
            else
            {
                int maxNum = nums[0];

                foreach (int number in nums)
                {
                    if (number > maxNum)
                    {
                        maxNum = number;
                    }
                }
                return maxNum;
            }
        }
    }
}
