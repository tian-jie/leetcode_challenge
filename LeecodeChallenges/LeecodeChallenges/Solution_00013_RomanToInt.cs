using System;
using System.Collections.Generic;

namespace LeetcodeChallenges
{
    public class Solution_00013_RomanToInt
    {
        //public int RomanToInt(string s)
        //{
        //    if (string.IsNullOrEmpty(s))
        //    {
        //        return 0;
        //    }
        //    Dictionary<char, int> leveldic = new Dictionary<char, int>()
        //    {
        //        {'I', 1 },{ 'V', 2}, {'X', 3 }, {'L', 4 }, { 'C', 5}, {'D', 6 }, {'M', 7 }
        //    };


        //    Dictionary<char, int> valuedic = new Dictionary<char, int>()
        //    {
        //        {'I', 1 },{ 'V', 5}, {'X', 10}, {'L', 50 }, { 'C', 100}, {'D', 500 }, {'M', 1000 }
        //    };


        //    var result = 0;

        //    // 如果下一个比这个大，则自己变成负数

        //    for (var i = 0; i < s.Length - 1; i++)
        //    {
        //        var c = s[i];
        //        // 有没有上一个
        //        if (leveldic[s[i + 1]] - leveldic[c] > 0)
        //        {
        //            result -= valuedic[c];
        //        }
        //        else
        //        {
        //            result += valuedic[c];
        //        }
        //    }
        //    return result + valuedic[s[s.Length - 1]];
        //}


        public int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            var leveldic = new int[26]{
                0,0,5,6,0,0,0,0,1,0,0,4,7,0,0,0,0,0,0,0,0,2,0,3,0,0
            };

            var valuedic = new int[26]{
                0,0,100,500,0,0,0,0,1,0,0,50,1000,0,0,0,0,0,0,0,0,5,0,10,0,0
            };

            var result = 0;

            // 如果下一个比这个大，则自己变成负数

            for (var i = 0; i < s.Length - 1; i++)
            {
                var c = s[i] - 'A';
                // 有没有上一个
                if (leveldic[s[i + 1]-'A'] - leveldic[c] > 0)
                {
                    result -= valuedic[c];
                }
                else
                {
                    result += valuedic[c];
                }
            }
            return result + valuedic[s[s.Length - 1] - 'A'];
        }
    }
}