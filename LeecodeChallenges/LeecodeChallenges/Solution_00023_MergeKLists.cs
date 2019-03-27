using System;
using System.Collections.Generic;
using System.Linq;

namespace LeecodeChallenges
{
    public class Solution_00023_MergeKLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var dic = new Dictionary<int, int>();
            foreach (var firstNode in lists)
            {
                for (var node = firstNode; node != null; node = node.next)
                {
                    var val = node.val;
                    if (dic.ContainsKey(val))
                    {
                        dic[val]++;
                    }
                    else
                    {
                        dic[val] = 1;
                    }
                }
            }

            ListNode returnNode1 = new ListNode(0);
            var node1 = returnNode1;

            var orderedKeys = dic.Keys.ToArray();
            Array.Sort(orderedKeys);
            foreach (var key in orderedKeys)
            {
                for (var i = 0; i < dic[key]; i++)
                {
                    var tn = new ListNode(key);
                    node1.next = tn;
                    node1 = node1.next;
                }
            }

            return returnNode1.next;

        }

    }


}