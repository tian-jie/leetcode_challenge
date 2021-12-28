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
        int halfLength = 0;

        public int MinimumDifference4(int[] nums)
        {
            numsInOrder = nums.OrderByDescending(a => a).ToArray();
            var length = nums.Length;
            halfLength = length / 2;
            // 负数全部处理成正数
            var min = numsInOrder[length - 1];
            if (min < 0)
            {
                min = min * -1;
                for (var i = 0; i < nums.Length; i++)
                {
                    numsInOrder[i] += min;
                }
            }
            sumAll = numsInOrder.Sum(a => a);
            // 找最接近平均数的，然后x2就可以
            Search(0, 0, halfLength, 0);
            return minDiffToAverage;
        }

        // 深度优先搜索
        private void Search(int index, int start, int end, int sum)
        {
            for (var i = start; i < end; i++)
            {
                if (index == halfLength - 1)
                {
                    var s = sum + numsInOrder[i];
                    var diff = Math.Abs(s * 2 - sumAll);
                    if (diff < minDiffToAverage)
                    {
                        minDiffToAverage = diff;
                    }
                    continue;
                }

                if (sum + numsInOrder[i] > (sumAll + 1) / 2)
                {
                    // 已经大了，再大就没有必要了
                    break;
                }

                // 每一次执行，就递归上一级的内容
                Search(index + 1, index + i + 1, halfLength, sum + numsInOrder[i]);
            }
        }

        public int MinimumDifference3(int[] nums)
        {
            var numsInOrder = nums.OrderBy(a => a).ToArray();
            var length = nums.Length;

            int[] nums1 = new int[length / 2];
            int[] nums2 = new int[length / 2];
            // 先大小大小分为两组
            for (var i = 0; i < length; i += 2)
            {
                nums1[i / 2] = numsInOrder[i];
                nums2[i / 2] = numsInOrder[i + 1];
            }

            // 直接双重循环，(length/2)^2，找出最小值
            var sum1 = nums1.Sum();
            var sum2 = nums2.Sum();
            // 给2组做差值
            int[] diff1 = new int[length / 2 - 1];
            for (var i = 0; i < length / 2 - 1; i++)
            {
                diff1[i] = nums1[i] - nums1[i + 1];
            }
            int[] diff2 = new int[length / 2 - 1];
            for (var i = 0; i < length / 2 - 1; i++)
            {
                diff2[i] = nums2[i] - nums2[i + 1];
            }
            // 再给diff做个排序
            var diff2InOrder = diff2.OrderBy(a => a).ToArray();

            var minDiff = Math.Abs(sum1 - sum2);
            for (var i = 0; i < length / 2; i++)
            {
                var d = nums1[i] - nums2[0];
                var sum11 = sum1 + d;
                var sum21 = sum2 - d;
                var df = Math.Abs(sum11 - sum21);
                if (df < minDiff)
                {
                    minDiff = df;
                }
                for (var j = 0; j < length / 2 - 1; j++)
                {
                    sum11 += diff2[j];
                    sum21 -= diff2[j];
                    df = Math.Abs(sum11 - sum21);
                    if (df < minDiff)
                    {
                        minDiff = df;
                    }
                }
            }

            for (var i = 0; i < length / 2; i++)
            {
                var d = nums2[i] - nums1[0];
                var sum11 = sum1 + d;
                var sum21 = sum2 - d;
                var df = Math.Abs(sum11 - sum21);
                if (df < minDiff)
                {
                    minDiff = df;
                }
                for (var j = 0; j < length / 2 - 1; j++)
                {
                    sum11 += diff1[j];
                    sum21 -= diff1[j];
                    df = Math.Abs(sum11 - sum21);
                    if (df < minDiff)
                    {
                        minDiff = df;
                    }
                }
            }

            return minDiff;
        }

        public int MinimumDifference2(int[] nums)
        {
            var numsInOrder = nums.OrderBy(a => a).ToArray();
            var length = nums.Length;
            int[] nums1 = new int[length / 2];
            int[] nums2 = new int[length / 2];
            // 先大小大小分为两组
            for (var i = 0; i < length / 2; i++)
            {
                nums1[i] = numsInOrder[i];
                nums2[i] = numsInOrder[length - i - 1];
            }

            var totalSum = nums.Sum();
            // 循环，看两组数的差值；
            // 确定两组数的差值后，挨个循环2组数字，找出两组数字中差值最接近“组差/2”的两个数，交换
            var hasSmaller = true;
            var minDiff = long.MaxValue;
            while (hasSmaller)
            {
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

                var diff = sum1 * 2 - totalSum;
                var index1 = 0;
                var index2 = 0;

                // 找两组数里差值最接近这个diff一半的2个数
                for (var i = 0; i < length / 2; i++)
                {
                    for (var j = 0; j < length / 2; j++)
                    {
                        var min = Math.Abs((nums1[i] - nums2[j]) * 2 - diff);
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


        public int MinimumDifference1(int[] nums)
        {
            numsInOrder = nums.OrderByDescending(a => a).ToArray();
            var length = nums.Length;
            halfLength = length / 2;
            // 负数全部处理成正数
            var min = numsInOrder[length - 1];
            if (min < 0)
            {
                min = min * -1;
                for (var i = 0; i < nums.Length; i++)
                {
                    numsInOrder[i] += min;
                }
            }
            sumAll = numsInOrder.Sum(a => a);
            var sumLeft = 0;

            for (var i00 = 0; i00 < halfLength; i00++)
            {
                sumLeft += numsInOrder[i00];
                var twiceSumLeft = sumLeft >> 1;
                if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                {
                    continue;
                }
                if (Check(sumLeft, 0))
                {
                    if (minDiffToAverage == 0)
                    {
                        return 0;
                    }
                    sumLeft -= numsInOrder[i00];
                    continue;
                }
                for (var i01 = i00 + 1; i01 < halfLength + 1; i01++)
                {
                    sumLeft += numsInOrder[i01];
                    if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                    {
                        continue;
                    }
                    if (Check(sumLeft, 1))
                    {
                        if (minDiffToAverage == 0)
                        {
                            return 0;
                        }
                        sumLeft -= numsInOrder[i01];
                        continue;
                    }
                    for (var i02 = i01 + 1; i02 < halfLength + 2; i02++)
                    {
                        sumLeft += numsInOrder[i02];
                        if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                        {
                            continue;
                        }
                        if (Check(sumLeft, 2))
                        {
                            if (minDiffToAverage == 0)
                            {
                                return 0;
                            }
                            sumLeft -= numsInOrder[i02];
                            continue;
                        }
                        for (var i03 = i02 + 1; i03 < halfLength + 3; i03++)
                        {
                            sumLeft += numsInOrder[i03];
                            if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                            {
                                continue;
                            }
                            if (Check(sumLeft, 3))
                            {
                                if (minDiffToAverage == 0)
                                {
                                    return 0;
                                }
                                sumLeft -= numsInOrder[i03];
                                continue;
                            }
                            for (var i04 = i03 + 1; i04 < halfLength + 4; i04++)
                            {
                                sumLeft += numsInOrder[i04];
                                if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                {
                                    continue;
                                }
                                if (Check(sumLeft, 4))
                                {
                                    if (minDiffToAverage == 0)
                                    {
                                        return 0;
                                    }
                                    sumLeft -= numsInOrder[i04];
                                    continue;
                                }
                                for (var i05 = i04 + 1; i05 < halfLength + 5; i05++)
                                {
                                    sumLeft += numsInOrder[i05];
                                    if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                    {
                                        continue;
                                    }
                                    if (Check(sumLeft, 5))
                                    {
                                        if (minDiffToAverage == 0)
                                        {
                                            return 0;
                                        }
                                        sumLeft -= numsInOrder[i05];
                                        continue;
                                    }
                                    for (var i06 = i05 + 1; i06 < halfLength + 6; i06++)
                                    {
                                        sumLeft += numsInOrder[i06];
                                        if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                        {
                                            continue;
                                        }
                                        if (Check(sumLeft, 6))
                                        {
                                            if (minDiffToAverage == 0)
                                            {
                                                return 0;
                                            }
                                            sumLeft -= numsInOrder[i06];
                                            continue;
                                        }
                                        for (var i07 = i06 + 1; i07 < halfLength + 7; i07++)
                                        {
                                            sumLeft += numsInOrder[i07];
                                            if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                            {
                                                continue;
                                            }
                                            if (Check(sumLeft, 7))
                                            {
                                                if (minDiffToAverage == 0)
                                                {
                                                    return 0;
                                                }
                                                sumLeft -= numsInOrder[i07];
                                                continue;
                                            }
                                            for (var i08 = i07 + 1; i08 < halfLength + 8; i08++)
                                            {
                                                sumLeft += numsInOrder[i08];
                                                if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                                {
                                                    continue;
                                                }
                                                if (Check(sumLeft, 8))
                                                {
                                                    if (minDiffToAverage == 0)
                                                    {
                                                        return 0;
                                                    }
                                                    sumLeft -= numsInOrder[i08];
                                                    continue;
                                                }
                                                for (var i09 = i08 + 1; i09 < halfLength + 9; i09++)
                                                {
                                                    sumLeft += numsInOrder[i09];
                                                    if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                                    {
                                                        continue;
                                                    }
                                                    if (Check(sumLeft, 9))
                                                    {
                                                        if (minDiffToAverage == 0)
                                                        {
                                                            return 0;
                                                        }
                                                        sumLeft -= numsInOrder[i09];
                                                        continue;
                                                    }
                                                    for (var i10 = i09 + 1; i10 < halfLength + 10; i10++)
                                                    {
                                                        sumLeft += numsInOrder[i10];
                                                        if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                                        {
                                                            continue;
                                                        }
                                                        if (Check(sumLeft, 10))
                                                        {
                                                            if (minDiffToAverage == 0)
                                                            {
                                                                return 0;
                                                            }
                                                            sumLeft -= numsInOrder[i10];
                                                            continue;
                                                        }
                                                        for (var i11 = i10 + 1; i11 < halfLength + 11; i11++)
                                                        {
                                                            sumLeft += numsInOrder[i11];
                                                            if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                                            {
                                                                continue;
                                                            }
                                                            if (Check(sumLeft, 11))
                                                            {
                                                                if (minDiffToAverage == 0)
                                                                {
                                                                    return 0;
                                                                }
                                                                sumLeft -= numsInOrder[i11];
                                                                continue;
                                                            }
                                                            for (var i12 = i11 + 1; i12 < halfLength + 12; i12++)
                                                            {
                                                                sumLeft += numsInOrder[i12];
                                                                if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                                                {
                                                                    continue;
                                                                }
                                                                if (Check(sumLeft, 12))
                                                                {
                                                                    if (minDiffToAverage == 0)
                                                                    {
                                                                        return 0;
                                                                    }
                                                                    sumLeft -= numsInOrder[i12];
                                                                    continue;
                                                                }
                                                                for (var i13 = i12 + 1; i13 < halfLength + 13; i13++)
                                                                {
                                                                    sumLeft += numsInOrder[i13];
                                                                    if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                                                    {
                                                                        continue;
                                                                    }
                                                                    if (Check(sumLeft, 13))
                                                                    {
                                                                        if (minDiffToAverage == 0)
                                                                        {
                                                                            return 0;
                                                                        }
                                                                        sumLeft -= numsInOrder[i13];
                                                                        continue;
                                                                    }
                                                                    for (var i14 = i13 + 1; i14 < halfLength + 14; i14++)
                                                                    {
                                                                        sumLeft += numsInOrder[i14];
                                                                        if (twiceSumLeft > sumAll && twiceSumLeft - sumAll > minDiffToAverage)
                                                                        {
                                                                            continue;
                                                                        }
                                                                        if (Check(sumLeft, 14))
                                                                        {
                                                                            if (minDiffToAverage == 0)
                                                                            {
                                                                                return 0;
                                                                            }
                                                                            sumLeft -= numsInOrder[i14];
                                                                            continue;
                                                                        }
                                                                        sumLeft -= numsInOrder[i14];
                                                                    }
                                                                    sumLeft -= numsInOrder[i13];
                                                                }
                                                                sumLeft -= numsInOrder[i12];
                                                            }
                                                            sumLeft -= numsInOrder[i11];
                                                        }
                                                        sumLeft -= numsInOrder[i10];
                                                    }
                                                    sumLeft -= numsInOrder[i09];
                                                }
                                                sumLeft -= numsInOrder[i08];
                                            }
                                            sumLeft -= numsInOrder[i07];
                                        }
                                        sumLeft -= numsInOrder[i06];
                                    }
                                    sumLeft -= numsInOrder[i05];
                                }
                                sumLeft -= numsInOrder[i04];
                            }
                            sumLeft -= numsInOrder[i03];
                        }
                        sumLeft -= numsInOrder[i02];
                    }
                    sumLeft -= numsInOrder[i01];
                }
                sumLeft -= numsInOrder[i00];
            }

            return minDiffToAverage;
        }
        private bool Check(int sumLeft, int depth)
        {
            // 到长度了，直接计算并且返回
            if (depth == halfLength - 1)
            {
                var diff = Math.Abs(sumAll - (sumLeft << 1));
                if (minDiffToAverage > diff)
                {
                    minDiffToAverage = diff;
                }
                return true;
            }
            return false;
        }


        public int MinimumDifference(int[] nums)
        {
            // 排序
            var numsInOrder = nums.OrderBy(a => a).ToArray();
            var length = nums.Length;
            var halfLength = length / 2;
            sumAll = numsInOrder.Sum();


            int[] nums1 = new int[length / 2];
            int[] nums2 = new int[length / 2];

            // 先大小大小分为两组
            Dictionary<int, List<int>> fullPermutationT1 = new Dictionary<int, List<int>>();
            Dictionary<int, List<int>> fullPermutationT2 = new Dictionary<int, List<int>>();
            fullPermutationT1.Add(0, new List<int>());
            fullPermutationT2.Add(0, new List<int>());
            for (var i = 0; i < halfLength; i++)
            {
                nums1[i] = numsInOrder[i];
                nums2[i] = numsInOrder[halfLength + i];
                fullPermutationT1.Add(i+1, new List<int>());
                fullPermutationT2.Add(i+1, new List<int>());
            }

            // 给两组组分别做全排列
            var bitCount = 0;
            for (var i = 0; i < (1 << (halfLength)); i++)
            {
                // 根据bit位决定取哪几个位置的数字加和
                var sum1 = SumByBit(nums1, i, out bitCount);
                fullPermutationT1[bitCount].Add(sum1);
                var sum2 = SumByBit(nums2, i, out bitCount);
                fullPermutationT2[bitCount].Add(sum2);
            }

            Dictionary<int, int[]> fullPermutation1 = new Dictionary<int, int[]>();
            Dictionary<int, int[]> fullPermutation2 = new Dictionary<int, int[]>();
            for (var i = 0; i <= halfLength; i++)
            {
                fullPermutation1[i] = fullPermutationT1[i].OrderBy(a => a).ToArray();
                fullPermutation2[i] = fullPermutationT2[i].OrderBy(a => a).ToArray();
            }

            // 现在就变成分别两组的问题了，fullPermutation1和fullPermutation2，分别对应
            // 0 - halfLength
            // 1 - halfLength-1...
            for (var i = 0; i <= halfLength; i++)
            {
                // 分别取出2个list
                var list1 = fullPermutation1[i];
                var list2 = fullPermutation2[halfLength - i];
                foreach (var l in list1)
                {
                    var diff = CalculateMinDiff(l, list2, sumAll);
                    if (diff < minDiffToAverage)
                    {
                        if (diff == 0)
                        {
                            return 0;
                        }

                        minDiffToAverage = diff;
                    }
                }
            }
            return minDiffToAverage;
        }

        // 由一个num，到另一个numsToFind里找，最接近target的数，doubleTarget为了防止出现0.5
        // 返回和target最接近的差值
        // 采用双指针法逼近中间值
        private int CalculateMinDiff(int num, int[] numsToFind, int doubleTarget)
        {
            var p1 = 0;
            var p2 = numsToFind.Length - 1;
            var doubleSum = 0;
            var p = p1;
            while (p1 <= p2)
            {
                doubleSum = (num + numsToFind[p]) << 1;
                if (doubleSum < doubleTarget)
                {
                    p1++;
                    p = p1;
                }
                else if (doubleSum > doubleTarget)
                {
                    p2--;
                    p = p2;
                }
                else
                {
                    return 0;
                }
            }

            return Math.Abs(doubleSum - doubleTarget);
        }

        private int SumByBit(int[] nums, int bitData, out int bitCount)
        {
            bitCount = 0;
            var sum = 0;
            var bitControl = 1;
            for (var i = 0; i < 32; i++, bitControl = bitControl << 1)
            {
                var b = bitData & bitControl;
                if (b > 0)
                {
                    bitCount++;
                    sum += nums[i];
                }
            }
            return sum;
        }
    }
}