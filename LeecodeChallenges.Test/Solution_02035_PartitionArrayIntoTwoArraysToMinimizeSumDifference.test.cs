using System;
using System.Collections.Generic;
using Solution_001694_ReformatPhoneNumberNS;
using Solution_00938_RangeSumBSTNS;
using Solution_02035_PartitionArrayIntoTwoArraysToMinimizeSumDifference;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_02035_PartitionArrayIntoTwoArraysToMinimizeSumDifferences
    {
        Solution obj = new Solution();

        [Fact]
        public void Case1()
        {
            var result = obj.MinimumDifference(new int[] { 1, 1 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case2()
        {
            var result = obj.MinimumDifference(new int[] { 1, 2 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void Case3()
        {
            var result = obj.MinimumDifference(new int[] { 3, 9, 7, 3 });
            Assert.Equal(2, result);
        }

        [Fact]
        public void Case4()
        {
            var result = obj.MinimumDifference(new int[] { -36, 36 });
            Assert.Equal(72, result);
        }

        [Fact]
        public void Case5()
        {
            var result = obj.MinimumDifference(new int[] { 2, -1, 0, 4, -2, -9 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case6()
        {
            var result = obj.MinimumDifference(new int[] { 576540, -3804995, -7884720, 1363877, 4631024, -6361235, -5803805, 9968336, 1771260, -6043832 });
            Assert.Equal(79702, result);
        }

        [Fact]
        public void Case7()
        {
            var result = obj.MinimumDifference(new int[] { 1, 0, 1000, 1000 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void Case8()
        {
            var result = obj.MinimumDifference(new int[] { -1, -2, -3, -4 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case9()
        {
            var result = obj.MinimumDifference(new int[] { 1,2,3,4,5,6 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void Case10_8()
        {
            var result = obj.MinimumDifference(new int[] { 2, -1, 0, 4, -2, -9, 1, 1 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case11_8()
        {
            var result = obj.MinimumDifference(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case13_12()
        {
            var result = obj.MinimumDifference(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case13_14()
        {
            var result = obj.MinimumDifference(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,13,14 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void Case13_16()
        {
            var result = obj.MinimumDifference(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case13_18()
        {
            var result = obj.MinimumDifference(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,17,18 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void Case13_20()
        {
            var result = obj.MinimumDifference(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18,19,20 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case12_10()
        {
            var result = obj.MinimumDifference(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void Case999()
        {
            var result = obj.MinimumDifference(new int[] { 576540, -3804995, -7884720, 1363877, 4631024, -6361235, -5803805, 9968336, 1771260, -6043832, -8313199, 3567219, 8162122, 7708575, 5505806, 7109884, 580515, 6177912, -3940512, 9603688, 1289170, -5222647, 8552243, -9574299, -4174878, -1695857, 932929, 438464, -5095053, 9328205 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void Case998()
        {
            var result = obj.MinimumDifference(new int[] { -5150290, 2992730, 4347322, 9786188, 1728007, -4145307, 115533, -404885, -7857648, -8968585, 4390106, -3152070, -2398649, -3458145, 6735052, -8071210, 980877, 9319938, -3356588, -5656999, -2938560, -9196815, 3987699, 8066476, -8015965, -7776270, 7626071, 0, -8884237, -8195050 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Case997_145()
        {
            var result = obj.MinimumDifference(new int[] { 17289, 29778, -21471, -61538, -6076, 18011, 61739, 58053, -63035, 41951, -462018, 72413, -74726, -3008, -81375, 83844, 75713, 98286, 41066, -18560, -87048, 65497, 27005, 41199, 26426, 33729, -11389, 13588, 4681, 80347 });
            Assert.Equal(1, result);
        }


    }
}