using System;
using System.Collections.Generic;
using Xunit;

namespace LeecodeChallenges.Test
{
    public class Solution_12_IntToRomanTest
    {
        Solution_12_IntToRoman obj = new Solution_12_IntToRoman();
        [Fact]
        public void case_1()
        {
            var result = obj.IntToRoman(1);

            Assert.Equal("I", result);
        }
        [Fact]
        public void case_2()
        {
            var result = obj.IntToRoman(3);

            Assert.Equal("III", result);
        }
        [Fact]
        public void case_3()
        {
            var result = obj.IntToRoman(4);

            Assert.Equal("IV", result);
        }
        [Fact]
        public void case_4()
        {
            var result = obj.IntToRoman(5);

            Assert.Equal("V", result);
        }
        [Fact]
        public void case_5()
        {
            var result = obj.IntToRoman(6);

            Assert.Equal("VI", result);
        }

        [Fact]
        public void case_6()
        {
            var result = obj.IntToRoman(8);

            Assert.Equal("VIII", result);
        }

        [Fact]
        public void case_7()
        {
            var result = obj.IntToRoman(9);

            Assert.Equal("IX", result);
        }

        [Fact]
        public void case_8()
        {
            var result = obj.IntToRoman(10);

            Assert.Equal("X", result);
        }

        [Fact]
        public void case_9()
        {
            var result = obj.IntToRoman(11);

            Assert.Equal("XI", result);
        }

        [Fact]
        public void case_10()
        {
            var result = obj.IntToRoman(12);

            Assert.Equal("XII", result);
        }

        [Fact]
        public void case_11()
        {
            var result = obj.IntToRoman(13);

            Assert.Equal("XIII", result);
        }

        [Fact]
        public void case_12()
        {
            var result = obj.IntToRoman(14);

            Assert.Equal("XIV", result);
        }

        [Fact]
        public void case_13()
        {
            var result = obj.IntToRoman(58);

            Assert.Equal("LVIII", result);
        }

        [Fact]
        public void case_14()
        {
            var result = obj.IntToRoman(1994);

            Assert.Equal("MCMXCIV", result);
        }

        [Fact]
        public void case_15()
        {
            var result = obj.IntToRoman(3999);

            Assert.Equal("MMMCMXCIX", result);
        }

        [Fact]
        public void case_16()
        {
            var result = obj.IntToRoman(14);

            Assert.Equal("XIV", result);
        }

        [Fact]
        public void case_999()
        {
            for (var i = 1; i < 4000; i++)
            {
                var result = obj.IntToRoman(i);
            }
        }


    }
}
