using System;
using System.Collections.Generic;
using Xunit;

namespace Solution
{
    public class LongestCommonPrefix_test
    {
        [Fact]
        public void Case1()
        {
            var nums = new List<string>() { "flower", "flow", "flight" };

            var obj = new Solution14();
            var result = obj.LongestCommonPrefix(nums.ToArray());

            Assert.Equal("fl", result);
        }
        [Fact]
        public void Case2()
        {
            var nums = new List<string>() { "flower", "flowar", "flawer" };

            var obj = new Solution14();
            var result = obj.LongestCommonPrefix(nums.ToArray());

            Assert.Equal("fl", result);
        }
        [Fact]
        public void Case3()
        {
            var nums = new List<string>() {  };

            var obj = new Solution14();
            var result = obj.LongestCommonPrefix(nums.ToArray());

            Assert.Equal("", result);
        }
        [Fact]
        public void Case4()
        {
            var nums = new List<string>() { "flower" };

            var obj = new Solution14();
            var result = obj.LongestCommonPrefix(nums.ToArray());

            Assert.Equal("flower", result);
        }
        [Fact]
        public void Case5()
        {
            var nums = new List<string>() { "flower", "flow", "flight" };

            var obj = new Solution14();
            var result = obj.LongestCommonPrefix(nums.ToArray());

            Assert.Equal("fl", result);
        }
        [Fact]
        public void Case6()
        {
            var nums = new List<string>() { "flower", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight", "flow", "flight" };

            var obj = new Solution14();
            var result = obj.LongestCommonPrefix(nums.ToArray());

            Assert.Equal("fl", result);
        }
    }
}