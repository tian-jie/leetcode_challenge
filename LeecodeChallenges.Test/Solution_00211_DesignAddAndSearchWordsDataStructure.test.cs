using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00211_DesignAddAndSearchWordsDataStructureTest
    {
        WordDictionary obj = new WordDictionary();
        [Fact]
        public void case_01()
        {
            string[] operation = { "WordDictionary", "addWord", "addWord", "addWord", "search", "search", "search", "search" };
            string[] words = { "", "bad", "dad", "mad", "pad", "bad", ".ad", "b.." };

            var result = Execute(operation, words);

            Assert.Equal("22220111", result);
        }

        [Fact]
        public void case_02()
        {
            string[] operation = { "WordDictionary", "search" };
            string[] words = { "", "bad" };

            var result = Execute(operation, words);

            Assert.Equal("20", result);
        }

        [Fact]
        public void case_03()
        {
            string[] operation = { "WordDictionary", "addWord", "addWord", "addWord", "addWord", "search", "search", "addWord", "search", "search", "search", "search", "search", "search" };
            string[] words = { "", "at", "and", "an", "add", "a", ".at", "bat", ".at", "an.", "a.d.", "b.", "a.d", "." };
            var result = Execute(operation, words);

            Assert.Equal("22222002110010", result);
        }

        [Fact]
        public void case_04()
        {
            string[] operation = { "WordDictionary", "addWord", "search" };
            string[] words = { "", "abc", ".bc" };

            var result = Execute(operation, words);

            Assert.Equal("221", result);
        }

        [Fact]
        public void case_05()
        {
            string[] operation = { "WordDictionary", "addWord", "search" };
            string[] words = { "", "abc", "a.c" };

            var result = Execute(operation, words);

            Assert.Equal("221", result);
        }

        [Fact]
        public void case_06()
        {
            string[] operation = { "WordDictionary", "addWord", "search" };
            string[] words = { "", "abc", "ab." };

            var result = Execute(operation, words);

            Assert.Equal("221", result);
        }

        [Fact]
        public void case_07()
        {
            string[] operation = { "WordDictionary", "addWord", "search" };
            string[] words = { "", "abc", "..c" };

            var result = Execute(operation, words);

            Assert.Equal("221", result);
        }

        [Fact]
        public void case_08()
        {
            string[] operation = { "WordDictionary", "addWord", "search" };
            string[] words = { "", "abc", ".b." };

            var result = Execute(operation, words);

            Assert.Equal("221", result);
        }

        [Fact]
        public void case_09()
        {
            string[] operation = { "WordDictionary", "addWord", "search" };
            string[] words = { "", "abc", "a.." };

            var result = Execute(operation, words);

            Assert.Equal("221", result);
        }

        [Fact]
        public void case_10()
        {
            string[] operation = { "WordDictionary", "addWord", "search" };
            string[] words = { "", "abc", "a." };

            var result = Execute(operation, words);

            Assert.Equal("220", result);
        }

        [Fact]
        public void case_11()
        {
            string[] operation = { "WordDictionary", "addWord", "search" };
            string[] words = { "", "abc", "." };

            var result = Execute(operation, words);

            Assert.Equal("220", result);
        }

        [Fact]
        public void case_12()
        {
            string[] operation = { "WordDictionary", "addWord", "search" };
            string[] words = { "", "abc", "..." };

            var result = Execute(operation, words);

            Assert.Equal("221", result);
        }

        [Fact]
        public void case_092()
        {
        }

        [Fact]
        public void case_093()
        {
        }



        string ConvertToString(bool?[] res)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var r in res)
            {
                if(r == null)
                {
                    sb.Append('2');
                }
                else if (r == true)
                {
                    sb.Append('1');
                }
                else if (r == false)
                {
                    sb.Append('0');
                }
            }
            return sb.ToString();
        }

        private string Execute(string[] operation, string[] words)
        {
            bool?[] result = new bool?[operation.Length];

            result[0] = null;
            for (var i = 1; i < operation.Length; i++)
            {
                var o = operation[i];
                var word = words[i];
                if (o == "addWord")
                {
                    obj.AddWord(word);

                    result[i] = null;
                    continue;
                }
                if (o == "search")
                {
                    result[i] = obj.Search(word);
                }
            }

            return ConvertToString(result);
        }
    }
}
