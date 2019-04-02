using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetcodeChallenges
{
    public class Solution_01012_NumDupDigitsAtMostN
    {
        Dictionary<int, int> dicSum = new Dictionary<int, int>()
            {
                {10,9}, { 100, 90}, {1000, 738}, {10000, 5274}, {100000, 32490}, {1000000, 168570}, {10000000, 712890}, {100000000, 2345850}, {1000000000, 5611770}
            };
        int[] keys = new int[] { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };

        public int NumDupDigitsAtMostN(int N)
        {
            if (N <= 10)
            {
                return 0;
            }

            // 缺陷：先要找一个小于N的最接近的不重复数，然后再做这种计算，去除掉各种边界条件即可。
            var numsList = FindClosetNoDuplicateDown(N);

            var sum = 0;
            var isFirstNumber = false;

            for (var numLevel = 0; numLevel < numsList.Count; numLevel++)
            {
                isFirstNumber = false;
                var dig = numsList[numLevel];
                if (sum == 0)
                {
                    // 第一位的特殊处理，就是加上小于这个位数的所有可能性
                    sum += dicSum[(int)Math.Pow(10, numsList.Count - 1)];
                    isFirstNumber = true;
                }

                var posibilities = 0;
                if (isFirstNumber)
                {
                    // 第一位数，只考虑不是0的情况，可能性为当前数字-1
                    posibilities = dig - 1;
                }
                else if (numLevel == numsList.Count - 1)
                {
                    // 最后一位数，考虑所有情况0-他自己
                    posibilities = dig + 1;
                }
                else
                {
                    // 中间的数字，考虑不带他自己的数字的可能性0-他自己-1
                    posibilities = dig;
                }

                for (var i = 0; i < numLevel; i++)
                {
                    if (numsList[i] <= dig)
                    {
                        posibilities--;
                    }
                }

                //if (posibilities <= 0)
                //{
                //    continue;
                //}
                ////else
                ////{
                ////    if (hasDupedThisRound && !hasDuped)
                ////    {
                ////        hasDuped = true;
                ////    }
                ////}
                for (var i = 0; i < numsList.Count - numLevel - 1; i++)
                {
                    posibilities *= 10 - i - numLevel - 1;
                }
                sum += posibilities;


                //if (hasDuped)
                //{
                //    break;
                //}
            }

            // 确定第一位数的算法
            return N - sum;

        }

        /// <summary>
        /// 计算出小于n的最大的不重复数字
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<int> FindClosetNoDuplicateDown(long n)
        {
            if (n > 9876543210)
            {
                return new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            }
            var result = new List<int>();

            // 拆数字
            for (var numLevel = 8; numLevel >= 0; numLevel--)
            {
                var digit = n / keys[numLevel];
                var dig = (int)digit % 10;

                if (result.Count > 0 || dig > 0)
                {
                    result.Add(dig);
                }
            }
            var hasDuplicate = true;
            while (hasDuplicate)
            {
                if (result[0] <= 0)
                {
                    result.RemoveAt(0);
                    for (var i = 0; i < result.Count; i++)
                    {
                        result[i] = 9 - i;
                    }
                }
                hasDuplicate = false;
                for (var i = 1; i < result.Count && !hasDuplicate; i++)
                {
                    for (var j = 0; j < i; j++)
                    {
                        if (result[i] == result[j])
                        {
                            var m = i;
                            result[m]--;
                            for (var x = m + 1; x < result.Count; x++)
                            {
                                result[x] = 9;
                            }

                            while (result[m] < 0)
                            {
                                for (var x = m; x < result.Count; x++)
                                {
                                    result[x] = 9;
                                }
                                result[m - 1]--;
                                m--;
                            }
                            hasDuplicate = true;

                            break;
                        }
                    }
                }
            }
            return result;
        }

    }
}
