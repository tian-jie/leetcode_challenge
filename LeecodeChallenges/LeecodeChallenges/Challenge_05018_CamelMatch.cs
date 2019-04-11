using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetcodeChallenges
{
    public class Challenge_05018_CamelMatch
    {
        public IList<bool> CamelMatch(string[] queries, string pattern)
        {
            var sb = new StringBuilder("^[a-z]*?");
            foreach(var c in pattern)
            {
                sb.Append(c);
                sb.Append("[a-z]*?");
            }
            sb.Append('$');

            var resultList = new List<bool>();
            Regex regex = new Regex(sb.ToString());
            foreach (var query in queries)
            {
                resultList.Add(regex.IsMatch(query));
            }
            return resultList;
        }
    }


}