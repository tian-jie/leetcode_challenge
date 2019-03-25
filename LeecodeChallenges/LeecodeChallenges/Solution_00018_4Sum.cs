using System;
using System.Collections.Generic;

namespace LeecodeChallenges
{
    public class Solution_00018_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            // 排序并清除掉超过4个相同的数字
            Array.Sort(nums);
            var numsList1 = new List<int>();

            var sameCnt = 0;
            var lastNum = int.MinValue;
            foreach (var n in nums)
            {
                if (n == lastNum)
                {
                    sameCnt++;
                    if (sameCnt >= 5)
                    {
                        continue;
                    }
                }
                else
                {
                    sameCnt = 1;
                    lastNum = n;
                }
                numsList1.Add(n);
            }

            nums = numsList1.ToArray();

            for (var i = 0; i < nums.Length - 3; i++)
            {
                for (var j = i + 1; j < nums.Length - 2; j++)
                {
                    var rs = nums[i] + nums[j];
                    var l = j + 1;
                    var r = nums.Length - 1;

                    while (l < r)
                    {
                        var rs1 = rs + nums[l] + nums[r];
                        if (rs1 > target)
                        {
                            r--;
                        }
                        else if (rs1 < target)
                        {
                            l++;
                        }
                        else
                        {
                            // 检查跟上一个是否一样
                            var isContain = false;
                            foreach(var rr in result)
                            {
                                if(rr[0]==nums[i] && rr[1] == nums[j] && rr[2] == nums[l] && rr[3] == nums[r])
                                {
                                    isContain = true;
                                    break;
                                }
                            }
                            if (!isContain)
                            {
                                result.Add(new List<int>() { nums[i], nums[j], nums[l], nums[r] });
                            }
                            l++;
                        }
                    }

                }
            }
            return result;
        }
    }
}
