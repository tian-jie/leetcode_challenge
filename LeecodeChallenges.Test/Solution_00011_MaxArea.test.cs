using System;
using System.Collections.Generic;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00011_MaxAreaTest
    {
        [Fact]
        public void case_1()
        {
            var nums = new List<int>() { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            var obj = new Solution_00011_MaxArea();
            var result = obj.MaxArea(nums.ToArray());

            Assert.Equal(49, result);
        }

        [Fact]
        public void case_2()
        {
            var nums = new List<int>() { 1, 12345678, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 7, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 1, 8, 6, 2, 5, 4, 8, 3, 987654321 };

            var obj = new Solution_00011_MaxArea();
            var result = obj.MaxArea(nums.ToArray());

            Assert.Equal(42864194016L, result);
        }

        [Fact]
        public void case_4()
        {
            var nums = new List<int>() { 1, 2 };

            var obj = new Solution_00011_MaxArea();
            var result = obj.MaxArea(nums.ToArray());

            Assert.Equal(1, result);
        }
        [Fact]
        public void case_5()
        {
            var nums = new List<int>() { 1 };

            var obj = new Solution_00011_MaxArea();
            var result = obj.MaxArea(nums.ToArray());

            Assert.Equal(0, result);
        }

    }
}