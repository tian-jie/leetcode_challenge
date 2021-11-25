using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution_00074_SearchA2DMatrix
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var height = matrix.Length;
        if (height == 0)
        {
            return false;
        }
        var width = matrix[0].Length;

        var numsSize = width * height;

        // 二分法查找
        int left = 0;
        int right = numsSize - 1;
        int targetIndex = -1;
        int midIndex = (left + right) / 2;

        while (left <= right)
        {
            var midValue = matrix[midIndex / width][midIndex % width];
            if (midValue > target)
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
            else if (midValue < target)
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
            else if (midValue == target)
            {
                targetIndex = midIndex;
                break;
            }


        }

        return targetIndex >= 0;

    }
}