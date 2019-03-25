using System;
using System.Collections.Generic;
using Xunit;

namespace LeecodeChallenges.Test
{
    public class Solution_00013_RomanToIntTest
    {
        Solution_00013_RomanToInt obj = new Solution_00013_RomanToInt();
        Solution_00012_IntToRoman intToRoman = new Solution_00012_IntToRoman();
        [Fact]
        public void case_01()
        {
            var result = obj.RomanToInt("I");

            Assert.Equal(1, result);
        }

        [Fact]
        public void case_02()
        {
            var result = obj.RomanToInt("");

            Assert.Equal(0, result);
        }

        [Fact]
        public void case_03()
        {
            var result = obj.RomanToInt("V");

            Assert.Equal(5, result);
        }

        [Fact]
        public void case_04()
        {
            var result = obj.RomanToInt("IV");

            Assert.Equal(4, result);
        }

        [Fact]
        public void case_05()
        {
            var result = obj.RomanToInt("VII");

            Assert.Equal(7, result);
        }

        [Fact]
        public void case_06()
        {
            var result = obj.RomanToInt("CV");

            Assert.Equal(105, result);
        }

        [Fact]
        public void case_07()
        {
            var result = obj.RomanToInt("IX");

            Assert.Equal(9, result);
        }

        //[Fact]
        //public void case_08()
        //{
        //    var result = obj.RomanToInt("IVX");

        //    Assert.Equal(6, result);
        //}

        //[Fact]
        //public void case_09()
        //{
        //    var result = obj.RomanToInt("VIX");

        //    Assert.Equal(4, result);
        //}

        [Fact]
        public void case_10()
        {
            var result = obj.RomanToInt("XIV");

            Assert.Equal(14, result);
        }

        [Fact]
        public void case_11()
        {
            var result = obj.RomanToInt("XVI");

            Assert.Equal(16, result);
        }


        [Fact]
        public void case_999()
        {
            var result = obj.RomanToInt("MCMXCIV");

            Assert.Equal(1994, result);
        }


        [Fact]
        public void case_998()
        {
            for (var l = 0; l < 1000; l++)
            {
                for (var i = 1; i < 3999; i++)
                {
                    var aa = intToRoman.IntToRoman(i);
                    var result = obj.RomanToInt(aa);

                    Assert.Equal(i, result);
                }
            }
        }



    }
}
