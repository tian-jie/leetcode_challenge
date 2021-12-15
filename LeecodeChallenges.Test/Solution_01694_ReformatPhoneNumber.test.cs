using System;
using System.Collections.Generic;
using Solution_001694_ReformatPhoneNumberNS;
using Solution_00938_RangeSumBSTNS;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_01694_ReformatPhoneNumberTest
    {
        Solution_01694_ReformatPhoneNumber obj = new Solution_01694_ReformatPhoneNumber();

        [Fact]
        public void Case1()
        {
            var result = obj.ReformatNumber("12");
            Assert.Equal("12", result);
        }

        [Fact]
        public void Case2()
        {
            var result = obj.ReformatNumber("123");
            Assert.Equal("123", result);
        }

        [Fact]
        public void Case3()
        {
            var result = obj.ReformatNumber("1234");
            Assert.Equal("12-34", result);
        }

        [Fact]
        public void Case4()
        {
            var result = obj.ReformatNumber("123 4-567");
            Assert.Equal("123-45-67", result);
        }

        [Fact]
        public void Case5()
        {
            var result = obj.ReformatNumber("--17-5 229 35-39475 ");
            Assert.Equal("175-229-353-94-75", result);
        }

        [Fact]
        public void Case6()
        {
            var result = obj.ReformatNumber("--12345 ");
            Assert.Equal("123-45", result);
        }

        [Fact]
        public void Case7()
        {
            var result = obj.ReformatNumber("--123-45 6 ");
            Assert.Equal("123-456", result);
        }

    }
}