using System.Collections.Generic;

namespace LeecodeChallenges
{
    public class Solution_00017_LetterCombinations
    {
        char[][] dic = {new char[]{},
            new char[] { }, new char[] { 'a', 'b', 'c'},new char[]{ 'd', 'e', 'f'},
                new char[]{ 'g', 'h', 'i'},new char[]{ 'j', 'k', 'l'},new char[]{ 'm', 'n', 'o'},
                    new char[]{ 'p', 'q', 'r', 's'},new char[]{ 't', 'u', 'v'},new char[]{ 'w', 'x', 'y' ,'z'}};


        List<string> result = new List<string>();

        public IList<string> LetterCombinations(string digits)
        {
            Combine("", digits, 0);
            return result;
        }

        /// <summary>
        /// 递归调用，s1不变，跟num的字母循环组合，再继续递归下一级，直到digitsIndex=digits.Length
        /// </summary>
        /// <returns>The combine.</returns>
        /// <param name="s1">S1.</param>
        /// <param name="digits">Digits.</param>
        /// <param name="digitsIndex">Digits index.</param>
        private void Combine(string s1, string digits, int digitsIndex)
        {
            if (digitsIndex >= digits.Length)
            {
                if(!string.IsNullOrEmpty(s1))result.Add(s1);
                return;
            }

            int num = digits[digitsIndex] - '0';

            foreach (var c in dic[num])
            {
                Combine(s1 + c, digits, digitsIndex + 1);
            }
        }
    }
}
