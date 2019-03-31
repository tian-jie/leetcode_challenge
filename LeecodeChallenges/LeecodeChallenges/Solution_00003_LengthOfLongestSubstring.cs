using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeetcodeChallenges
{
    public class Solution_00003_LengthOfLongestSubstring
    {
        const int BUFFER = 95;
        public int LengthOfLongestSubstring1(string s)
        {
            // 创建一个字母mapping
            var dic = new Dictionary<char, int>();
            var maxLength = 0;



            foreach (var c in s)
            {
                var cLen = 0;
                if (dic.ContainsKey(c))
                {
                    cLen = dic[c];
                    // 如果有，看数字是不是最长，最长就替换maxLength
                    if (maxLength < cLen)
                    {
                        maxLength = cLen;
                    }
                    dic[c] = 0;
                    List<char> list = new List<char>();
                    list.AddRange(dic.Keys);
                    foreach (var c1 in list)
                    {
                        // 所有value>dic[c]的都要设置为0
                        if (dic[c1] > cLen)
                        {
                            if (maxLength < dic[c1])
                            {
                                maxLength = dic[c1];
                            }
                            dic.Remove(c1);
                        }
                    }
                }

                {
                    dic[c] = 0;

                    List<char> list = new List<char>();
                    list.AddRange(dic.Keys);
                    foreach (var c1 in list)
                    {
                        dic[c1]++;
                    }
                }
            }

            foreach (var v in dic.Values)
            {
                if (maxLength < v)
                {
                    maxLength = v;
                }
            }

            return maxLength;
        }


        public int LengthOfLongestSubstring(string s)
        {
            // 创建一个字母mapping
            var dic = new int[BUFFER];
            for (var i = 0; i < BUFFER; i++)
            {
                dic[i] = -1;
            }
            var maxLength = 0;


            foreach (var c0 in s)
            {
                var c = c0 - ' ';
                var cLen = 0;
                if (dic[c] >= 0)
                {
                    cLen = dic[c];
                    // 如果有，看数字是不是最长，最长就替换maxLength
                    if (maxLength < cLen)
                    {
                        maxLength = cLen;
                    }
                    

                    //for (var i = 0; i < BUFFER; i++)
                    //{
                    //    var c1 = dic[i];
                    //    // 所有value>dic[c]的都要设置为0
                    //    if (c1 > cLen)
                    //    {
                    //        if (maxLength < c1)
                    //        {
                    //            maxLength = c1;
                    //        }
                    //        dic[i] = -1;
                    //    }
                    //}
                }

                {
                    dic[c] = 0;

                    for (var i = 0; i < BUFFER; i++)
                    {
                        var c1 = dic[i];
                        if (cLen > 0 && c1 > cLen)
                        {
                            // 所有value>dic[c]的都要删掉
                            if (maxLength < c1)
                            {
                                maxLength = c1;
                            }
                            dic[i] = -1;
                        }

                        if (dic[i] >= 0)
                        {
                            dic[i]++;
                        }
                    }
                }
            }

            for (var i = 0; i < BUFFER; i++)
            {
                if (maxLength < dic[i])
                {
                    maxLength = dic[i];
                }
            }

            return maxLength;
        }
    }
}
