using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetcodeChallenges
{
    public class Solution_00027_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            var length = nums.Length;
            var removed = 0;
            for (var i = 0; i < length; i++)
            {
                nums[i - removed] = nums[i];
                removed += nums[i] == val ? 1 : 0;

            }
            return length - removed;
        }

    }
}
