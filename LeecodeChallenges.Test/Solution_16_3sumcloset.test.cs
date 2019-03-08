using System;
using System.Collections.Generic;
using Xunit;

namespace LeecodeChallenges.Test
{
    public class Solution_16_3sumClosetTest
    {
        [Fact]
        public void Case1()
        {
            var nums = new List<int>() { -1, 2, 1, -4 };

            var obj = new Solution_16_3sumCloset();
            var result = obj.ThreeSumClosest(nums.ToArray(), 1);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Case2()
        {
            var nums = new List<int>() { 0,0,0 };

            var obj = new Solution_16_3sumCloset();
            var result = obj.ThreeSumClosest(nums.ToArray(), 2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Case3()
        {
            var nums = new List<int>() { 1,2,3 };

            var obj = new Solution_16_3sumCloset();
            var result = obj.ThreeSumClosest(nums.ToArray(), 3);

            Assert.Equal(6, result);
        }

    }
}
