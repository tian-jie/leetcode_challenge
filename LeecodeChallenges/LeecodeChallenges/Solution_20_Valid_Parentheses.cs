using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeecodeChallenges
{
    public class Solution_20_Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            var c = s[0];
            if (c == '}' || c == ']' || c == ')')
            {
                return false;
            }

            var list = new List<char>() { s[0] };
            var length = s.Length;

            for (var i = 1; i < length; i++)
            {
                var cnt = list.Count;
                c = s[i];
                if (cnt == 0)
                {
                    if (c == '}' || c == ']' || c == ')')
                    {
                        return false;
                    }
                    else
                    {
                        list.Add(s[i]);
                        continue;
                    }
                }
                var last = list[cnt - 1];
                if ((last == '{' && c == '}') || (last == '[' && c == ']') || (last == '(' && c == ')'))
                {
                    list.RemoveAt(cnt - 1);
                }
                else
                {
                    list.Add(s[i]);
                }
            }

            return list.Count == 0;
        }

    }
}
