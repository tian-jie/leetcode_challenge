using System;
using System.Collections.Generic;

namespace LeecodeChallenges
{
    public class Solution_00019_RemoveNthFromEnd
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode skipPreNode = head;
            var pNode = head;

            for (var i = 0; i < n; i++)
            {
                pNode = pNode.next;
            }
            if (pNode == null)
            {
                return head.next;
            }
            pNode = pNode.next;
            // skipPreNode始终落后n个节点
            while (pNode != null)
            {
                skipPreNode = skipPreNode.next;

                pNode = pNode.next;
            }

            // 循环完成后落后n个节点，干脆跳过

            skipPreNode.next = skipPreNode.next.next;

            return head;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}