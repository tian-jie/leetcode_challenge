using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetcodeChallenges
{
    public class Solution_01015_NumDupDigitsAtMostN
    {
        Dictionary<int, int> dicSum = new Dictionary<int, int>()
            {
                {1,10}, { 10, 90}, {100, 738}, {1000, 5274}, {10000, 32490}, {100000, 168570}, {1000000, 712890}, {10000000, 2345850}, {100000000, 5611770}
            };
        int[] keys = new int[] { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };

        public int NumDupDigitsAtMostN(int N)
        {
            if (N <= 10)
            {
                return 0;
            }

            var n = N;

            var hasNumsList = new List<int>();
            var hasDowngrade = false;
            var sum = 0;
            // 好像要从上往下走，看数字的长度
            for (var i = 8; i >= 0; i--)
            {
                var digit = !hasDowngrade ? n / keys[i] : 9;
                if (sum == 0 && digit > 0)
                {
                    if (digit > 1)
                    {
                        // 第一个数
                        // (第一位-1)*9*8......
                        var tmp = digit - 1;
                        for (var j = 0; j < i; j++)
                        {
                            tmp *= 9 - j;
                        }
                        sum = tmp;
                    }
                    // 加上第一位不是1的数
                    sum += dicSum[(int)Math.Pow(10, i - 1)];
                    hasNumsList.Add(digit);
                }
                else if (sum > 0)
                {
                    // 非第一位
                    // 确定当前位置的可取值个数（自己-1，减去hasNumsList的数量），取≤自己的最大数字
                    var me = digit % 10;
                    if (me == 0)
                    {
                        hasNumsList.Add(me);
                        continue;
                    }
                    if (i == 0 && !hasNumsList.Contains(me))
                    {
                        me++;
                    }
                    for (var j = 0; j < hasNumsList.Count; j++)
                    {
                        if (hasNumsList[j] == me)
                        {
                            me--;
                            hasDowngrade = true;
                        }
                    }
                    if (me <= 0)
                    {
                        continue;
                    }

                    // 取定最小值后再看有效数量
                    var validNums = i == 0 ? me + 1 : me;
                    foreach (var num in hasNumsList)
                    {
                        if (num < me)
                        {
                            validNums--;
                        }
                    }
                    hasNumsList.Add(me);

                    var hasNums = hasNumsList.Count;
                    for (var j = 0; j < i; j++)
                    {
                        validNums *= 10 - hasNums - j;
                    }

                    sum += validNums;
                }
            }


            // 确定第一位数的算法
            return N - sum;

        }

        //private int MaxNoDupDigit(int n)
        //{
        //    var hasNumsList = new List<int>();
        //    var hasDowngrade = false;
        //    for (var i = 8; i >= 0; i--)
        //    {
        //        var digit = !hasDowngrade ? n / keys[i] : 9;
        //        if(digit == 0 && )
        //        for (var j = 0; j < hasNumsList.Count; j++)
        //        {
        //            if (digit == hasNumsList[j])
        //            {
        //                digit--;
        //                hasDowngrade = true;
        //            }
        //        }
        //        hasNumsList.Add(digit);
        //    }

        //    var result = 0;
        //    foreach(var n1 in hasNumsList)
        //    {
        //        result = result * 10 + n1;
        //    }

        //    return result;
        //}
    }
}
