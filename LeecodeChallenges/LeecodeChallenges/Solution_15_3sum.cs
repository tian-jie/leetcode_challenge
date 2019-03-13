using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeecodeChallenges
{
    public class Solution_15_3sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 3)
            {
                return result;
            }

            // 要先排序啊先排序
            var numsList = new List<int>(nums);
            numsList.Sort();

            var newNumsList = new List<int>() { numsList[0] };
            // 如果有相同的数据，排除掉一个数据最多剩下2个
            var repeatNo = 0;
            var last = numsList[0];
            for (var i = 1; i < numsList.Count; i++)
            {
                var n = numsList[i];
                if (n == last)
                {
                    repeatNo++;
                    if (repeatNo > 2)
                    {
                        continue;
                    }
                }
                else
                {
                    repeatNo = 0;
                }

                newNumsList.Add(n);

                last = n;
            }

            nums = newNumsList.ToArray();
            var length = nums.Length;
            var lasti = nums[0] - 1;
            for (var i = 0; i < length; i++)
            {
                var ni = nums[i];
                if (ni == lasti)
                {
                    continue;
                }
                var L = i + 1;
                var R = length - 1;

                while (L < R)
                {
                    var r = ni + nums[L] + nums[R];
                    if (r > 0)
                    {
                        R--;
                    }
                    else if (r < 0)
                    {
                        L++;
                    }
                    else if (r == 0)
                    {
                        // 一组结果
                        var isEqual = false;
                        foreach (var rr in result)
                        {
                            if (ni == rr[0] && nums[L] == rr[1] && nums[R] == rr[2])
                            {
                                isEqual = true;
                                break;
                            }
                        }
                        if (!isEqual)
                        {
                            result.Add(new List<int>()
                            {
                                ni, nums[L], nums[R]
                            });
                        }

                        L++;
                        R--;
                    }
                }
                lasti = nums[i];
            }

            return result;
        }


    }
}
