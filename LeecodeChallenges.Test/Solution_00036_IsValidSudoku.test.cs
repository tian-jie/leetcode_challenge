using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeChallenges.Test
{
    public class Solution_00036_IsValidSudokuTest
    {
        Solution_00036_IsValidSudoku obj = new Solution_00036_IsValidSudoku();

        [Fact]
        public void Case_01()
        {
            var s =
                "53..7...." +
                "6..195..." +
                ".98....6." +
                "8...6...3" +
                "4..8.3..1" +
                "7...2...6" +
                ".6....28." +
                "...419..5" +
                "....8..79";
            var arr = ConvertStringToIntArr(s);
            obj.IsValidSudoku(arr);
            var result = obj.IsValidSudoku(arr);
            Assert.True(result);
        }

        [Fact]
        public void Case_02()
        {
            var s =
                "83..7...." +
                "6..195..." +
                ".98....6." +
                "8...6...3" +
                "4..8.3..1" +
                "7...2...6" +
                ".6....28." +
                "...419..5" +
                "....8..79";
            var arr = ConvertStringToIntArr(s);
            obj.IsValidSudoku(arr);
            var result = obj.IsValidSudoku(arr);
            Assert.False(result);
        }

        [Fact]
        public void Case_03()
        {
            var s =
                ".2.....4." +
                "7...6...8" +
                "..6...7.." +
                "...5.9..." +
                ".1.....5." +
                "...4.6..." +
                "..4...8.." +
                "5...2...4" +
                ".8.....6.";
            var arr = ConvertStringToIntArr(s);
            var result = obj.IsValidSudoku(arr);
            Assert.True(result);
        }

        [Fact]
        public void Case_04()
        {
            var s =
                "...2...63" +
                "3....54.1" +
                "..1..398." +
                ".......9." +
                "...538..." +
                ".3......." +
                ".263..5.." +
                "5.37....8" +
                "47...1...";
            var arr = ConvertStringToIntArr(s);
            var result = obj.IsValidSudoku(arr);
            Assert.True(result);
        }



        private char[][] ConvertStringToIntArr(string s)
        {
            var num = new char[9][];
            for(var i=0; i<9; i++)
            {
                num[i] = new char[9];
            }

            for (var i = 0; i < 81; i++)
            {
                var m = i / 9;
                var n = i % 9;

                num[m][n] = s[i];
            }

            return num;
        }

        private string ConvertIntArrToString(char[][] num)
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < 81; i++)
            {
                var m = i / 9;
                var n = i % 9;

                sb.Append(num[m][n]);
            }

            return sb.ToString();
        }
    }
}