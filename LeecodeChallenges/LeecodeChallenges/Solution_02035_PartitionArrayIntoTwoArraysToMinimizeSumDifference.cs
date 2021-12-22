using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace Solution_02035_PartitionArrayIntoTwoArraysToMinimizeSumDifference
{
    public class Solution
    {
        int minDiffToAverage = int.MaxValue;
        int sumAll = 0;
        int[] numsInOrder;

        //public int MinimumDifference(int[] nums)
        //{
        //    numsInOrder = nums.OrderBy(a => a).ToArray();
        //    var length = nums.Length;
        //    // 负数全部处理成正数
        //    var min = numsInOrder[0];
        //    if (min < 0)
        //    {
        //        min = min * -1;
        //        for (var i=0; i<nums.Length; i++)
        //        {
        //            numsInOrder[i] += min;
        //        }
        //    }
        //    sumAll = numsInOrder.Sum(a => a);
        //    // 找最接近平均数的，然后x2就可以
        //    Search(length / 2 - 1, length / 2 - 1, length - 1, 0);
        //    return minDiffToAverage;
        //}

        //// 深度优先搜索
        //private void Search(int index, int start, int end, int sum)
        //{
        //    for (var i = start; i <= end; i++)
        //    {
        //        if (index == 0)
        //        {
        //            var s = sum + numsInOrder[i];
        //            var diff = Math.Abs(s * 2 - sumAll);
        //            if (diff < minDiffToAverage)
        //            {
        //                minDiffToAverage = diff;
        //            }
        //            continue;
        //        }

        //        if (sum + numsInOrder[i] > (sumAll + 1) / 2)
        //        {
        //            // 已经大了，再大就没有必要了
        //            break;
        //        }

        //        // 每一次执行，就递归上一级的内容
        //        Search(index - 1, start - 1, i-1, sum + numsInOrder[i]);
        //    }
        //}

        public int MinimumDifference(int[] nums)
        {
            //var numsInOrder = nums.OrderBy(a => a).ToArray();
            var length = nums.Length;
            int[] nums1 = new int[length / 2];
            int[] nums2 = new int[length / 2];
            // 先大小大小分为两组
            for (var i=0; i<length/2; i++)
            {
                nums1[i] = nums[i];
                nums2[i] = nums[length - i - 1];
            }

            // 循环，看两组数的差值；
            // 确定两组数的差值后，挨个循环2组数字，找出两组数字中差值最接近“组差/2”的两个数，交换
            var hasSmaller = true;
            var minDiff = long.MaxValue;
            var totalIndex = 1;
            while (hasSmaller)
            {
                Console.WriteLine("Round {0}", totalIndex++);
                hasSmaller = false;
                long sum1 = 0;
                long sum2 = 0;
                foreach (var num in nums1)
                {
                    sum1 += num;
                }
                foreach (var num in nums2)
                {
                    sum2 += num;
                }


                if (sum1 - sum2 == 0)
                {
                    return 0;
                }

                var diff = sum1 - sum2;
                var index1 = 0;
                var index2 = 0;

                Console.WriteLine(" sum1 = {0}, sum2 = {1}, diff = {2}", sum1, sum2, diff);

                // 找两组数里差值最接近这个diff一半的2个数
                for (var i = 0; i < length / 2; i++)
                {
                    for (var j = 0; j < length / 2; j++)
                    {
                        var min = Math.Abs((nums1[i] - nums2[j]) - (diff >> 1));
                        if (min < minDiff)
                        {
                            minDiff = min;
                            index1 = i;
                            index2 = j;
                            hasSmaller = true;
                        }
                    }
                }

                if (hasSmaller)
                {
                    // 交换
                    var tmp = nums1[index1];
                    nums1[index1] = nums2[index2];
                    nums2[index2] = tmp;
                }
                else
                {
                    return (int)Math.Abs(diff);
                }
            }
            return 0;
        }
    }
}