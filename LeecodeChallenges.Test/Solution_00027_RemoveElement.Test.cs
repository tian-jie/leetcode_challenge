using System;
using System.Collections.Generic;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00027_RemoveElementTest
    {
        Solution_00027_RemoveElement obj = new Solution_00027_RemoveElement();
        [Fact]
        public void case_01()
        {
            var nums = new List<int>() { 3, 2, 2, 3 };
            var na = nums.ToArray();
            var result = obj.RemoveElement(na, 3);

            Assert.Equal(2, result);
            Assert.Equal("2,2,", Common.IntListToString(na, 2));
        }

        [Fact]
        public void case_02()
        {
            var nums = new List<int>() { 0, 1, 2, 2, 3, 0, 4, 2 };
            var na = nums.ToArray();
            var result = obj.RemoveElement(na, 2);

            Assert.Equal(5, result);
            Assert.Equal("0,1,3,0,4,", Common.IntListToString(na, 5));
        }

        [Fact]
        public void case_03()
        {
            var nums = new List<int>() { 0, 0, 0 };
            var na = nums.ToArray();
            var result = obj.RemoveElement(na, 0);

            Assert.Equal(0, result);
        }


    }
}
