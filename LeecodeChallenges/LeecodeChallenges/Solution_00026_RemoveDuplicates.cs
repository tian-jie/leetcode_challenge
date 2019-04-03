using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetcodeChallenges
{
    public class Solution_00026_RemoveDuplicates
    {
        public int RemoveDuplicates(int[] nums)
        {
            var length = nums.Length;
            if (length <= 1)
            {
                return length;
            }

            // 第一位肯定不重复
            var left = 0;
            var right = 1;
            var duplicatedNum = 0;

            while (left < length && right < length)
            {
                if(nums[right] == nums[left])
                {
                    right++;
                    duplicatedNum++;
                }
                else
                {
                    left++;
                    nums[left] = nums[right];
                    right++;
                }
            }

            return length - duplicatedNum;
        }

    }
}
