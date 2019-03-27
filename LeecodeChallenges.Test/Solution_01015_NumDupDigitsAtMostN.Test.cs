using System;
using System.Collections.Generic;
using Xunit;

namespace LeecodeChallenges.Test
{
    public class Solution_01015_NumDupDigitsAtMostNTest
    {
        Solution_01015_NumDupDigitsAtMostN obj = new Solution_01015_NumDupDigitsAtMostN();
        [Fact]
        public void case_01()
        {
            var result = obj.IntToRoman(1);

            Assert.Equal("I", result);
        }


    }
}
