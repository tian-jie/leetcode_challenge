using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LeetcodeChallenges
{
    public class Solution_00042_Trap
    {
        /// <summary>
        /// 先计算总面积，然后在减去墙面积
        /// 采用左右逼近法计算各个矩形的面积
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap(int[] height)
        {
            if (height.Length == 0)
            {
                return 0;
            }
            var maxNum = height.Max();

            // 左右逼近
            var left = 0;
            var area = 0;
            var lastPos = 0;
            var leftMaxIndex = 0;
            var rightMaxIndex = 0;
            if (height[0] <= maxNum)
            {
                while (left < height.Length)
                {
                    try
                    {
                        var curHeight = height[left];

                        if (curHeight <= height[lastPos])
                        {
                            continue;
                        }

                        // 计算当前的面积
                        var distance = left - lastPos;
                        var area1 = distance * height[lastPos];
                        area += area1;

                        if (curHeight == maxNum)
                        {
                            leftMaxIndex = left;
                            break;
                        }
                        lastPos = left;
                    }
                    finally
                    {
                        left++;
                    }
                }
            }
            else
            {
                leftMaxIndex = left;
            }

            // 反向从右走
            var right = height.Length - 1;
            lastPos = right;
            if (height[right] != maxNum)
            {
                while (right >= 0 && height[right] <= maxNum)
                {
                    try
                    {
                        var curHeight = height[right];

                        if (curHeight <= height[lastPos])
                        {
                            continue;
                        }

                        // 计算当前的面积
                        var distance = lastPos - right;
                        var area1 = distance * height[lastPos];
                        area += area1;

                        if (curHeight == maxNum)
                        {
                            rightMaxIndex = right;
                            break;
                        }
                        lastPos = right;
                    }
                    finally
                    {
                        right--;
                    }
                }
            }
            else
            {
                rightMaxIndex = right;
            }


            area += maxNum * (rightMaxIndex - leftMaxIndex + 1);
            // 计算墙面面积
            var a1 = 0;
            foreach (var h in height)
            {
                a1 += h;
            }
            return area - a1;
        }


    }
}
