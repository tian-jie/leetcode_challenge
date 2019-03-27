using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeecodeChallenges
{
    public class Solution_01015_NumDupDigitsAtMostN
    {
        public int NumDupDigitsAtMostN(int N)
        {
            var dic = new Dictionary<int, int>()
            {
                {1,0 }, { 10, 0}, {100, 0}, {1000, 0}, {10000, 0}, {100000, 0}, {1000000, 0}, {10000000, 0}, {100000000, 0}, {1000000000, 0}
            };

            var level = 1;
            var n = N;
            while (n > 9)
            {
                var digit = n % 10;
                n = n / 10;
                level *= 10;
                dic[level] = digit;
            }


        }
    }
}
