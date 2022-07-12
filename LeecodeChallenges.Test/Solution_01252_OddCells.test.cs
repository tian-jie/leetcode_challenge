using System;
using System.Collections.Generic;
using System.Text;
using Solution_01252_OddCells;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_01252_OddCellsTest
    {
        Solution obj = new Solution();

        [Fact]
        public void Case1()
        {
            var m = 2;
            var n = 3;

            var result = obj.OddCells(m, n, new int[][] { new int[] { 0, 1 }, new int[] { 1, 1 } });
            Assert.Equal(6, result);
        }

        [Fact]
        public void Case2()
        {
            var m = 2;
            var n = 2;

            var result = obj.OddCells(m, n, new int[][] { new int[] { 1, 1 }, new int[] { 0, 0 } });
            Assert.Equal(0, result);
        }





    }
}