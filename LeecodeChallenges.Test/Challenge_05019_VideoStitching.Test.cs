using System;
using System.Collections.Generic;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Challenge_05019_VideoStitchingTest
    {
        Challenge_05019_VideoStitching obj = new Challenge_05019_VideoStitching();
        [Fact]
        public void case_01()
        {
            int[][] clips = { new int[] { 0, 2 }, new int[] { 4, 6 }, new int[] { 8, 10 }, new int[] { 1, 9 }, new int[] { 1, 5 }, new int[] { 5, 9 } };

            var result = obj.VideoStitching(clips, 10);

            Assert.Equal(3, result);
        }
        [Fact]
        public void case_02()
        {
            int[][] clips = { new int[] { 0, 1 }, new int[] { 1, 2 } };

            var result = obj.VideoStitching(clips, 5);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void case_03()
        {
            int[][] clips = { new int[] { 0, 1 }, new int[] { 6, 8 }, new int[] { 0,2 }, new int[] { 5,6 }, new int[] { 0,4 }
            , new int[] { 0, 3 }, new int[] { 6, 7 }, new int[] { 1, 3 }, new int[] { 4, 7 }, new int[] { 1, 4 }, new int[] { 2, 5 }
            , new int[] { 2, 6 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 5, 7 }, new int[] { 6, 9 }};

            var result = obj.VideoStitching(clips, 9);

            Assert.Equal(3, result);
        }

        [Fact]
        public void case_04()
        {
            int[][] clips = { new int[] { 0, 4 }, new int[] { 2, 8 } };

            var result = obj.VideoStitching(clips, 5);

            Assert.Equal(2, result);
        }

        [Fact]
        public void case_05()
        {
            int[][] clips = { new int[] { 0, 4 }, new int[] { 4, 7 }, new int[] { 6, 9 } };

            var result = obj.VideoStitching(clips, 9);

            Assert.Equal(3, result);
        }

        [Fact]
        public void case_06()
        {
            int[][] clips = { new int[] { 0, 1 }, new int[] { 0, 4 }, new int[] { 4, 7 }, new int[] { 6, 9 } };

            var result = obj.VideoStitching(clips, 9);

            Assert.Equal(3, result);
        }



    }
}
