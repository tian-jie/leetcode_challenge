using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeecodeChallenges
{
    public class Solution_00011_MaxArea
    {
        public long MaxArea(int[] height)
        {
            long r = 0;
            var length = height.Length;
            if(length < 2)
            {
                return 0;
            }

            for (var i = 0; i < length; i++)
            {
                for (var j = i + 1; j < length; j++)
                {
                    long tmp = (height[i] < height[j] ? height[i] : height[j]) * (long)(j - i);
                    if (tmp > r)
                    {
                        r = tmp;
                    }
                }
            }

            return r;
        }

    }
}
