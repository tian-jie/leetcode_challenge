using System;
using System.Collections.Generic;

namespace LeetcodeChallenges
{
    public class Solution_00022_GenerateParenthesis
    {
        IList<string> _result = new List<string>();
        int length = 0;

        public IList<string> GenerateParenthesis(int n)
        {
            length = n;
            GenerateParenthesis("(", 1, 0);

            return _result;
        }

        private void GenerateParenthesis(string s, int lcnt, int rcnt)
        {
            if (lcnt == rcnt && lcnt == length)
            {
                _result.Add(s);
                return;
            }

            if (lcnt < length)
            {
                GenerateParenthesis(s + '(', lcnt + 1, rcnt);
            }
            if (lcnt > rcnt)
            {
                GenerateParenthesis(s + ')', lcnt, rcnt + 1);
            }
        }

    }
}
