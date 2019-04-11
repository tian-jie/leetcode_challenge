using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Challenge_05018_CamelMatchTest
    {
        Challenge_05018_CamelMatch obj = new Challenge_05018_CamelMatch();
        [Fact]
        public void case_01()
        {
            var queries = new List<string>()
            {
                "FooBar","FooBarTest","FootBall","FrameBuffer","ForceFeedBack"
            };
            var result = obj.CamelMatch(queries.ToArray(), "FB");

            Assert.Equal("10110", ConvertBoolListToString(result));
        }

        [Fact]
        public void case_02()
        {
            var queries = new List<string>()
            {
                "FooBar","FooBarTest","FootBall","FrameBuffer","ForceFeedBack"
            };
            var result = obj.CamelMatch(queries.ToArray(), "FoBa");

            Assert.Equal("10100", ConvertBoolListToString(result));
        }

        [Fact]
        public void case_03()
        {
            var queries = new List<string>()
            {
                "FooBar","FooBarTest","FootBall","FrameBuffer","ForceFeedBack"
            };
            var result = obj.CamelMatch(queries.ToArray(), "FoBaT");

            Assert.Equal("01000", ConvertBoolListToString(result));
        }
        [Fact]
        public void case_04()
        {
            var queries = new List<string>()
            {
                "FooBar","FooBarTest","FaotBall","FrameBuffer","ForceFeedBack"
            };
            var result = obj.CamelMatch(queries.ToArray(), "FoBa");

            Assert.Equal("10100", ConvertBoolListToString(result));
        }

        private string ConvertBoolListToString(IList<bool> bl)
        {
            var sb = new StringBuilder();
            foreach(var b in bl)
            {
                sb.Append(b ? '1':'0');
            }

            return sb.ToString();
        }
    }
}
