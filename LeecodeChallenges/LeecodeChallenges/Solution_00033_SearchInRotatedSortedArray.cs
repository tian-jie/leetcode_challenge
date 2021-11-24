using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution_00033_SearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {
        var numsSize = nums.Length;
        var numst = new int[numsSize];
        var offset = 0;
        for (int i = 1; i < numsSize; i++)
        {
            if (nums[i - 1] > nums[i])
            {
                offset = i;
            }
        }

        // 重新排列
        int loopi = offset;
        for (int i = 0; i < numsSize; i++, loopi++)
        {
            if (loopi == numsSize)
            {
                loopi -= numsSize;
            }
            numst[i] = nums[loopi];
        }

        // 二分法查找
        int left = 0;
        int right = numsSize - 1;
        int targetIndex = -1;
        int midIndex = (left + right) / 2;

        while (left <= right)
        {
            //Console.WriteLine($"left: {left}, right: {right}, center: {midIndex}, midValue: {numst[midIndex]}, target: {target}");
            //if (midIndex == left || midIndex == right) {
            //    if (numst[midIndex] == target)
            //    {
            //        targetIndex = midIndex + offset;
            //        if (targetIndex >= numsSize)
            //        {
            //            targetIndex -= numsSize;
            //        }
            //    }
            //    break;
            //}
            //else 
            if (numst[midIndex] > target)
            {
                // 左边折半
                if (right == midIndex)
                {
                    right--;
                }
                else
                {
                    right = midIndex;
                }
                midIndex = (right + left) / 2;
            }
            else if (numst[midIndex] < target)
            {
                // 右边折半
                if (left == midIndex)
                {
                    left++;
                }
                else
                {
                    left = midIndex;
                }
                midIndex = (right + left) / 2;
            }
            else if (numst[midIndex] == target)
            {
                targetIndex = midIndex + offset;
                if (targetIndex >= numsSize)
                {
                    targetIndex -= numsSize;
                }
                break;
            }


        }

        return targetIndex == -1 ? -1 : targetIndex;

    }
}