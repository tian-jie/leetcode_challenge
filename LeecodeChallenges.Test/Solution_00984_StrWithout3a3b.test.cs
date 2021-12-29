using System;
using System.Collections.Generic;
using System.Text;
using Solution_00984_StrWithout3a3b;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00984_StrWithout3a3b_Test
    {
        Solution obj = new Solution();

        [Fact]
        public void Case1()
        {
            var result = obj.StrWithout3a3b(0, 0);
            Assert.Equal("", result);
        }

        [Fact]
        public void Case2()
        {
            var result = obj.StrWithout3a3b(1, 0);
            Assert.Equal("a", result);
        }

        [Fact]
        public void Case3()
        {
            var result = obj.StrWithout3a3b(0, 1);
            Assert.Equal("b", result);
        }

        [Fact]
        public void Case4()
        {
            var result = obj.StrWithout3a3b(1, 1);
            Assert.Equal("ab", result);
        }

        [Fact]
        public void Case5()
        {
            var result = obj.StrWithout3a3b(2, 1);
            Assert.Equal("baa", result);
        }

        [Fact]
        public void Case5_1()
        {
            var result = obj.StrWithout3a3b(2, 2);
            Assert.Equal("baba", result);
        }

        [Fact]
        public void Case6()
        {
            var result = obj.StrWithout3a3b(3, 1);
            Assert.Equal("aaba", result);
        }

        [Fact]
        public void Case7()
        {
            var result = obj.StrWithout3a3b(4, 1);
            Assert.Equal("aabaa", result);
        }

        [Fact]
        public void Case8()
        {
            var result = obj.StrWithout3a3b(5, 2);
            Assert.Equal("aabaaba", result);
        }

        [Fact]
        public void Case9()
        {
            var result = obj.StrWithout3a3b(2, 5);
            Assert.Equal("bbabbab", result);
        }

        [Fact]
        public void Case10()
        {
            var result = obj.StrWithout3a3b(1, 3);
            Assert.Equal("bbab", result);
        }

    }
}