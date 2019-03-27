using System;
using System.Collections.Generic;
using System.Linq;

namespace LeecodeChallenges
{
    public class Solution_00024_SwapPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            var second = head.next;

            // 双数指向前一个，单数指向后三个(如果没了就后2个）
            var current = head;
            var last = head;
            var next = head;

            var i = 0;
            while (next != null)
            {
                // 保护
                next = current.next;
                if (i % 2 == 1)
                {
                    // 双数，前一个
                    current.next = last;
                }
                else
                {
                    // 单数，下3个
                    // 如果下一个为空，则为空
                    // 如果下2个为空，则为空
                    // 如果下3个为空，则指向下2个
                    var tmp = current;

                    if (current.next == null)
                    {
                        current.next = null;
                    }
                    else if (current.next.next == null)
                    {
                        current.next = null;
                    }
                    else if (current.next.next.next == null)
                    {
                        current.next = current.next.next;
                    }
                    else
                    {
                        current.next = current.next.next.next;
                    }

                }


                i++;
                last = current;
                current = next;
            }
            return second;

        }

    }


}