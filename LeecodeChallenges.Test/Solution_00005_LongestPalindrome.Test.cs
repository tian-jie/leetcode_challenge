using System;
using System.Collections.Generic;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00005_LongestPalindromeTest
    {
        Solution_00005_LongestPalindrome obj = new Solution_00005_LongestPalindrome();

        [Fact]
        public void Case1()
        {
            var s = "ababcba";
            var result = obj.LongestPalindrome(s);

            Assert.Equal("abcba", result);
        }

        [Fact]
        public void Case2()
        {
            var s = "a";
            var result = obj.LongestPalindrome(s);

            Assert.Equal("a", result);
        }

        [Fact]
        public void Case3()
        {
            var s = "abcdefg";
            var result = obj.LongestPalindrome(s);

            Assert.Equal("a", result);
        }

        [Fact]
        public void Case4()
        {
            var s = "1234567890987654321";
            var result = obj.LongestPalindrome(s);

            Assert.Equal("1234567890987654321", result);
        }

        [Fact]
        public void Case5()
        {
            var s = "12345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321";
            var result = obj.LongestPalindrome(s);

            Assert.Equal("12345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321123456789098765432112345678909876543211234567890987654321", result);
        }

        [Fact]
        public void Case6()
        {
            var s = "abccccab";
            var result = obj.LongestPalindrome(s);

            Assert.Equal("cccc", result);
        }

        [Fact]
        public void Case7()
        {
            var s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabcaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            var result = obj.LongestPalindrome(s);

            Assert.Equal("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", result);
        }

        [Fact]
        public void Case8()
        {
            var s = "aaaaaaaaa";
            var result = obj.LongestPalindrome(s);

            Assert.Equal("aaaaaaaaa", result);
        }
        [Fact]
        public void Case9()
        {
            var s = "aaaaaaaaab";
            var result = obj.LongestPalindrome(s);

            Assert.Equal("aaaaaaaaa", result);
        }

    }
}