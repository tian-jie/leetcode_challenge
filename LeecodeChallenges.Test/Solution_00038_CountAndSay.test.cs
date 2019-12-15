using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00038_CountAndSayTest
    {
        Solution_00038_CountAndSay obj = new Solution_00038_CountAndSay();

        [Fact]
        public void Case_01()
        {
            var result = obj.CountAndSay(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void Case_02()
        {
            var result = obj.CountAndSay(2);
            Assert.Equal("11", result);
        }

        [Fact]
        public void Case_03()
        {
            var result = obj.CountAndSay(3);
            Assert.Equal("21", result);
        }

        [Fact]
        public void Case_04()
        {
            var result = obj.CountAndSay(4);
            Assert.Equal("1211", result);
        }

        [Fact]
        public void Case_05()
        {
            var result = obj.CountAndSay(5);
            Assert.Equal("111221", result);
        }

        [Fact]
        public void Case_06()
        {
            var result = obj.CountAndSay(6);
            Assert.Equal("312211", result);
        }

        [Fact]
        public void Case_07()
        {
            var result = obj.CountAndSay(7);
            Assert.Equal("13112221", result);
        }

        [Fact]
        public void Case_08()
        {
            var result = obj.CountAndSay(8);
            Assert.Equal("1113213211", result);
        }

    }
}

