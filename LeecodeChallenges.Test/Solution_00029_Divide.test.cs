using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00029_DivideTest
    {
        Solution_00029_Divide obj = new Solution_00029_Divide();

        [Fact]
        public void Case_01()
        {
            var result = obj.Divide(10, 3);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Case_02()
        {
            var result = obj.Divide(-10, 3);
            Assert.Equal(-3, result);
        }

        [Fact]
        public void Case_03()
        {
            var result = obj.Divide(-10, -3);
            Assert.Equal(3, result);
        }
        [Fact]
        public void Case_04()
        {
            var result = obj.Divide(-10, -3);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Case_05()
        {
            var result = obj.Divide(-2147483648, -1);
            Assert.Equal(2147483647, result);
        }

        [Fact]
        public void Case_06()
        {
            var result = obj.Divide(-3333333, 1);
            Assert.Equal(-3333333, result);
        }

        [Fact]
        public void Case_07()
        {
            var result = obj.Divide(-2147483648, 1);
            Assert.Equal(-2147483648, result);
        }


        [Fact]
        public void Case_08()
        {
            var result = obj.Divide(-2147483648, 2);
            Assert.Equal(-1073741824, result);
        }

        [Fact]
        public void Case_09()
        {
            var result = obj.Divide(-1010369383, -2147483648);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case_10()
        {
            var result = obj.Divide(1, 2);
            Assert.Equal(0, result);
        }


    }
}

