using System.Linq;
using System.Text;
using Xunit;

namespace LeecodeChallenges.Test
{
    public class Solution_00017_LetterCombinationsTest
    {
        Solution_00017_LetterCombinations obj = new Solution_00017_LetterCombinations();
        [Fact]
        public void case_01()
        {
            var result = obj.LetterCombinations("23");
            StringBuilder sb = new StringBuilder();
            foreach (var r in result.OrderBy(a => a))
            {
                sb.Append(r);
            }
            Assert.Equal("adaeafbdbebfcdcecf", sb.ToString());
        }

        [Fact]
        public void case_02()
        {
            var result = obj.LetterCombinations("234");
            Assert.Equal(27, result.Count);
        }

        [Fact]
        public void case_03()
        {
            var result = obj.LetterCombinations("2345");
            Assert.Equal(81, result.Count);
        }

        [Fact]
        public void case_04()
        {
            var result = obj.LetterCombinations("23456");
            Assert.Equal(243, result.Count);
        }

        [Fact]
        public void case_05()
        {
            var result = obj.LetterCombinations("234567");
            Assert.Equal(972, result.Count);
        }


        [Fact]
        public void case_06()
        {
            var result = obj.LetterCombinations("2345678");
            Assert.Equal(2916, result.Count);
        }

        [Fact]
        public void case_07()
        {
            var result = obj.LetterCombinations("23456789");
            Assert.Equal(11664, result.Count);
        }

        [Fact]
        public void case_08()
        {
            var result = obj.LetterCombinations("7");
            StringBuilder sb = new StringBuilder();
            foreach (var r in result.OrderBy(a => a))
            {
                sb.Append(r);
            }
            Assert.Equal("pqrs", sb.ToString());

        }

        [Fact]
        public void case_09()
        {
            var result = obj.LetterCombinations("1");
            StringBuilder sb = new StringBuilder();
            foreach (var r in result.OrderBy(a => a))
            {
                sb.Append(r);
            }
            Assert.Equal("", sb.ToString());

        }

        [Fact]
        public void case_11()
        {
            var result = obj.LetterCombinations("");
            Assert.Equal(0, result.Count);
        }

    }
}
