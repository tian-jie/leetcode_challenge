using System.Linq;
using System.Text;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00022_GenerateParenthesisTest
    {
        Solution_00022_GenerateParenthesis obj = new Solution_00022_GenerateParenthesis();
        [Fact]
        public void case_01()
        {
            var result = obj.GenerateParenthesis(1);
            StringBuilder sb = new StringBuilder();
            foreach (var r in result.OrderBy(a => a))
            {
                sb.Append(r);
            }
            Assert.Equal("()", sb.ToString());
        }

        [Fact]
        public void case_02()
        {
            var result = obj.GenerateParenthesis(2);
            StringBuilder sb = new StringBuilder();
            foreach (var r in result.OrderBy(a => a))
            {
                sb.Append(r);
            }
            Assert.Equal("(())()()", sb.ToString());
        }

        [Fact]
        public void case_03()
        {
            var result = obj.GenerateParenthesis(3);
            StringBuilder sb = new StringBuilder();
            foreach (var r in result.OrderBy(a => a))
            {
                sb.Append(r);
            }
            Assert.Equal("((()))(()())(())()()(())()()()", sb.ToString());
        }

        [Fact]
        public void case_04()
        {
            var result = obj.GenerateParenthesis(4);
            StringBuilder sb = new StringBuilder();
            foreach (var r in result.OrderBy(a => a))
            {
                sb.Append(r);
            }
            Assert.Equal(14, result.Count);
        }

        [Fact]
        public void case_05()
        {
            var result = obj.GenerateParenthesis(5);
            Assert.Equal(42, result.Count);
        }

        [Fact]
        public void case_10()
        {
            var result = obj.GenerateParenthesis(10);
            Assert.Equal(16796, result.Count);
        }

        [Fact]
        public void case_15()
        {
            var result = obj.GenerateParenthesis(12);
            Assert.Equal(208012, result.Count);
        }

    }
}
