using System;
using System.Collections.Generic;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_01012_NumDupDigitsAtMostNTest
    {
        Solution_01012_NumDupDigitsAtMostN obj = new Solution_01012_NumDupDigitsAtMostN();
        [Fact]
        public void case_01()
        {
            var result = obj.NumDupDigitsAtMostN(1);

            Assert.Equal(0, result);
        }

        [Fact]
        public void case_02()
        {
            var result = obj.NumDupDigitsAtMostN(9);

            Assert.Equal(0, result);
        }

        [Fact]
        public void case_03()
        {
            var result = obj.NumDupDigitsAtMostN(10);

            Assert.Equal(0, result);
        }

        [Fact]
        public void case_04()
        {
            var result = obj.NumDupDigitsAtMostN(11);

            Assert.Equal(1, result);
        }

        [Fact]
        public void case_05()
        {
            var result = obj.NumDupDigitsAtMostN(100);

            Assert.Equal(10, result);
        }

        [Fact]
        public void case_06()
        {
            var result = obj.NumDupDigitsAtMostN(1000);

            Assert.Equal(262, result);
        }

        [Fact]
        public void case_07()
        {
            var result = obj.NumDupDigitsAtMostN(2000);

            Assert.Equal(758, result);
        }

        [Fact]
        public void case_08()
        {
            var result = obj.NumDupDigitsAtMostN(2500);

            Assert.Equal(1034, result);
        }

        [Fact]
        public void case_081()
        {
            var result = obj.NumDupDigitsAtMostN(2507);

            Assert.Equal(1036, result);
        }

        [Fact]
        public void case_082()
        {
            var result = obj.NumDupDigitsAtMostN(2517);

            Assert.Equal(1039, result);
        }

        [Fact]
        public void case_09()
        {
            var result = obj.NumDupDigitsAtMostN(3000);

            Assert.Equal(1254, result);
        }

        [Fact]
        public void case_091()
        {
            var result = obj.NumDupDigitsAtMostN(3200);

            Assert.Equal(1342, result);
        }

        [Fact]
        public void case_092()
        {
            var result = obj.NumDupDigitsAtMostN(3230);

            Assert.Equal(1358, result);
        }

        [Fact]
        public void case_093()
        {
            var result = obj.NumDupDigitsAtMostN(3231);

            Assert.Equal(1359, result);
        }

        [Fact]
        public void case_10()
        {
            var result = obj.NumDupDigitsAtMostN(3234);

            Assert.Equal(1362, result);
        }

        [Fact]
        public void case_11()
        {
            var result = obj.NumDupDigitsAtMostN(1000000);

            Assert.Equal(831430, result);
        }

        [Fact]
        public void case_12()
        {
            var result = obj.NumDupDigitsAtMostN(100000000);

            Assert.Equal(97654150, result);
        }

        [Fact]
        public void case_13()
        {
            var result = obj.NumDupDigitsAtMostN(20);

            Assert.Equal(1, result);
        }

        [Fact]
        public void case_14()
        {
            var result = obj.NumDupDigitsAtMostN(23);

            Assert.Equal(2, result);
        }

        [Fact]
        public void case_15()
        {
            var result = obj.NumDupDigitsAtMostN(110);

            Assert.Equal(12, result);
        }

        [Fact]
        public void case_16()
        {
            var result = obj.NumDupDigitsAtMostN(44412);

            Assert.Equal(28722, result);
        }

        [Fact]
        public void case_97()
        {
            var result = obj.NumDupDigitsAtMostN(998);

            Assert.Equal(260, result);
        }

        [Fact]
        public void case_981()
        {
            var result = obj.NumDupDigitsAtMostN(900);

            Assert.Equal(234, result);
        }

        [Fact]
        public void case_982()
        {
            var result = obj.NumDupDigitsAtMostN(990);

            Assert.Equal(252, result);
        }

        [Fact]
        public void case_98()
        {
            var result = obj.NumDupDigitsAtMostN(999);

            Assert.Equal(261, result);
        }

        [Fact]
        public void case_99()
        {
            var result = obj.NumDupDigitsAtMostN(999999999);

            Assert.Equal(994388229, result);
        }

        [Fact]
        public void case_9991()
        {
            var result = obj.FindClosetNoDuplicateDown(999999999);

            Assert.Equal(987654321, ListToInt(result));
        }
        [Fact]
        public void case_9992()
        {
            var result = obj.FindClosetNoDuplicateDown(10);

            Assert.Equal(10, ListToInt(result));
        }
        [Fact]
        public void case_9993()
        {
            var result = obj.FindClosetNoDuplicateDown(1);

            Assert.Equal(1, ListToInt(result));
        }
        [Fact]
        public void case_9994()
        {
            var result = obj.FindClosetNoDuplicateDown(1111);

            Assert.Equal(1098, ListToInt(result));
        }

        private int ListToInt(List<int> l)
        {
            var r = 0;
            foreach(var n in l)
            {
                r = r * 10 + n;
            }
            return r;
        }
    }
}
