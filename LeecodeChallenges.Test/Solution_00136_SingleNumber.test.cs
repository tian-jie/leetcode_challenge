﻿using System;
using System.Collections.Generic;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00136_SingleNumberTest
    {
        Solution_00136_SingleNumber obj = new Solution_00136_SingleNumber();

        [Fact]
        public void Case1()
        {
            var nums = new List<int>() { 1, 2, 1 };

            var result = obj.SingleNumber(nums.ToArray());

            Assert.Equal(2, result);
        }

        [Fact]
        public void Case2()
        {
            var nums = new List<int>() { 1, 2, 2, 1, 3 };

            var result = obj.SingleNumber(nums.ToArray());

            Assert.Equal(3, result);
        }

        [Fact]
        public void Case3()
        {
            var nums = new List<int>() { 2, 2, 1 };

            var result = obj.SingleNumber(nums.ToArray());

            Assert.Equal(1, result);
        }
        [Fact]
        public void Case4()
        {
            var nums = new List<int>() { 2 };

            var result = obj.SingleNumber(nums.ToArray());

            Assert.Equal(2, result);
        }
        [Fact]
        public void Case5()
        {
            var nums = new List<int>() { 1, 3, 2, 2, 1, 3, 0 };

            var result = obj.SingleNumber(nums.ToArray());

            Assert.Equal(0, result);
        }

    }
}