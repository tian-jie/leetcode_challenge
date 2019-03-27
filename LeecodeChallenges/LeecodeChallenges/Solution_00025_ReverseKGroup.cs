using System;
using System.Collections.Generic;
using System.Linq;

namespace LeecodeChallenges
{
    public class Solution_00025_ReverseKGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }

            var tNode = head;
            var i1 = 0;
            for (; i1 < k - 1; i1++)
            {
                if (tNode.next == null)
                {
                    return head;
                }
                tNode = tNode.next;
            }

            var firstK = (i1 == k - 1 ? tNode : head);

            // 双数指向前一个，单数指向后三个(如果没了就后2个）
            var current = head;
            var last = head;
            var next = head;
            ListNode nextStop = null;

            var i = 0;
            while (next != null && current != nextStop)
            {
                // 保护
                next = current.next;
                if (i % k != 0)
                {
                    // 双数，前一个
                    current.next = last;
                }
                else
                {
                    // 单数，下2k-1个
                    // 如果下一个为空，则为空
                    // 如果下n个为空，则为空
                    // 如果下3个为空，则指向下2个
                    var tmp = current;
                    var tmpK1 = current; // k的位置，如果2k-1前有空了，就等于k
                    var tmpIndex = 0;
                    while (tmp.next != null && tmpIndex < 2 * k - 1)
                    {
                        tmp = tmp.next;
                        tmpIndex++;
                        if(tmpIndex == k)
                        {
                            tmpK1 = tmp;
                        }
                    }
                    // 无论是否到达，都等于tmp；只处理一种情况：tmpIndex == 2*k-1
                    if(tmpIndex == k - 1)
                    {
                        current.next = null;
                    }
                    else if (tmpIndex < 2 * k - 1)
                    {
                        nextStop = tmpK1;
                        current.next = tmpK1;
                    }
                    else
                    {
                        current.next = tmp;
                    }
                }


                i++;
                last = current;
                current = next;
            }
            return firstK;

        }

    }


}