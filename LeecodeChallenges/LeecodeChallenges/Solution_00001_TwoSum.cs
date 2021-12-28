using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace Solution_00001_TwoSum
{
    public class Solution
    {
        /// <summary>
        /// 标准算法，类似于冒泡排序的算法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum1(int[] nums, int target)
        {
            var length = nums.Length;
            for (var i = 0; i < length - 1; i++)
            {
                for (var j = i + 1; j < length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 尝试了先冒泡排序，后双指针逼近法，发现排序太耗时了
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum2(int[] nums, int target)
        {
            var length = nums.Length;
            // 冒泡排序
            var numsIndex = new int[length];
            for(var i=0; i<length; i++)
            {
                numsIndex[i] = i;
            }
            for (var i=0; i<length; i++)
            {
                for(var j=i+1; j<length; j++)
                {
                    if(nums[j] < nums[i])
                    {
                        var tmp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tmp;
                        // 交换的同时，交换index，以便最终出index
                        tmp = numsIndex[i];
                        numsIndex[i] = numsIndex[j];
                        numsIndex[j] = tmp;
                    }
                }
            }
            var p1 = 0;
            var p2 = length - 1;
            while (p1 < p2)
            {
                var sum = nums[p1] + nums[p2];
                if (sum > target)
                {
                    p2--;
                }
                else if (sum < target)
                {
                    p1++;
                }
                else
                {
                    return new int[] { numsIndex[p1], numsIndex[p2] };
                }
            }
            return null;
        }


        public int[] TwoSum(int[] nums, int target)
        {
            var length = nums.Length;
            var numsList = new List<kv>();
            for (var i = 0; i < length; i++)
            {
                numsList.Add(new kv()
                {
                    Index = i,
                    Value = nums[i]
                });
            }

            var numsArray = numsList.OrderBy(a => a.Value).ToArray();

            var p1 = 0;
            var p2 = length - 1;
            while (p1 < p2)
            {
                var sum = numsArray[p1].Value + numsArray[p2].Value;
                if (sum > target)
                {
                    p2--;
                }
                else if (sum < target)
                {
                    p1++;
                }
                else
                {
                    return new int[] { numsArray[p1].Index, numsArray[p2].Index };
                }
            }
            return null;
        }
    }

    public class kv
    {
        public int Index;
        public int Value;
    }
}