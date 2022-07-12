using System;
using System.Collections.Generic;
using System.Text;
using Solution_00676_MagicDictionary;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00676_MagicDictionary_Test
    {
        MagicDictionary obj = new MagicDictionary();

        [Fact]
        public void Case1()
        {
            obj.BuildDict(new string[] { "hello", "leetcode" });
            var result = obj.Search("hello");
            Assert.False(result);
        }

        [Fact]
        public void Case2()
        {
            obj.BuildDict(new string[] { "hello", "leetcode" });
            var result = obj.Search("hhllo");
            Assert.True(result);
        }

        [Fact]
        public void Case3()
        {
            obj.BuildDict(new string[] { "hello", "leetcode" });
            var result = obj.Search("hell");
            Assert.False(result);
        }

        [Fact]
        public void Case4()
        {
            obj.BuildDict(new string[] { "hello", "leetcode" });
            var result = obj.Search("leetcoded");
            Assert.False(result);
        }

        [Fact]
        public void Case5()
        {
            obj.BuildDict(new string[] { "hello", "leetcode" });
            var result = obj.Search("leetcodd");
            Assert.True(result);
        }

        [Fact]
        public void Case6()
        {
            obj.BuildDict(new string[] { "hello", "hallo", "leetcode" });
            var result = obj.Search("hello");
            Assert.True(result);
        }

        [Fact]
        public void Case7()
        {
            obj.BuildDict(new string[] { "hello", "hallo", "leetcode" });
            var result = obj.Search("hell");
            Assert.False(result);
        }

        [Fact]
        public void Case8()
        {
            obj.BuildDict(new string[] { "a", "ab", "abc" });
            var result = obj.Search("bbc");
            Assert.True(result);
        }

        [Fact]
        public void Case9()
        {
            obj.BuildDict(new string[] { "a", "b", "ab", "abc", "abcabacbababdbadbfaejfoiawfjaojfaojefaowjfoawjfoawj", "abcdefghijawefe", "aefawoifjowajfowafjeoawjfaow", "cba", "cas", "aaewfawi", "babcda", "bcd", "awefj" });
            var result = obj.Search("bbc");
            Assert.True(result);
        }

        [Fact]
        public void Case10()
        {
            obj.BuildDict(new string[] { "a", "b", "ab", "abc", "abcabacbababdbadbfaejfoiawfjaojfaojefaowjfoawjfoawj", "abcdefghijawefe", "aefawoifjowajfowafjeoawjfaow", "cba", "cas", "aaewfawi", "babcda", "bcd", "awefj" });
            var result = obj.Search("bb");
            Assert.True(result);
        }

        [Fact]
        public void Case11()
        {
            obj.BuildDict(new string[] { "a", "b", "ab", "abc", "abcd" });
            var result = obj.Search("bb");
            Assert.True(result);
        }

        [Fact]
        public void Case12()
        {
            obj.BuildDict(new string[] { "a", "b", "ab", "abc" });
            var result = obj.Search("bbc");
            Assert.True(result);
        }

        [Fact]
        public void Case13()
        {
            obj.BuildDict(new string[] { "a", "b", "ab" });
            var result = obj.Search("bb");
            Assert.True(result);
        }




    }
}