using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeecodeChallenges
{
    public class Solution_16_3sumCloset
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var result = new List<IList<int>>();

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

            // 前3个先给一个预设最小值
            var closet = nums[0] + nums[1] + nums[2] - target;
            var minDistance = nums[0] + nums[1] + nums[2];

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
                    var r = ni + nums[L] + nums[R] - target;
                    if (r >= minDistance && closet > 0)
                    {
                        R--;
                    }
                    else if (r <= minDistance && closet < 0)
                    {
                        L++;
                    }
                    else
                    {
                        closet = ni + nums[L] + nums[R];


                        L++;
                        R--;
                    }
                }
                lasti = nums[i];
            }

            return closet;
        }


    }
}
