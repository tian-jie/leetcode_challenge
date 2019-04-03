using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeChallenges.Test
{
    public static class Common
    {
        public static String NodeListToString(ListNode node)
        {
            var sb = new StringBuilder();

            for (var pNode = node; pNode != null; pNode = pNode.next)
            {
                sb.Append(pNode.val.ToString());
            }

            return sb.ToString();
        }

        public static String IntListToString(int[] l)
        {
            var sb = new StringBuilder();
            foreach(var n in l)
            {
                sb.Append(n.ToString());
                sb.Append(',');
            }

            return sb.ToString();
        }
    }
}
